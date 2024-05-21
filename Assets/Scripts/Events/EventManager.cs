using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    
[SerializeField] private EventData[] eventData;


[Header("Scene Objects")]
[SerializeField] private GameObject[] ballonObject;

[SerializeField] private TextMeshProUGUI[] speechText;


[Header("Frames")]
[SerializeField] private SpriteRenderer[] frames;
[SerializeField] private SpriteRenderer result;


[Header("variables frames")]
[SerializeField] private SpriteRenderer resultFrame;
[SerializeField] private Sprite[] groupSprite;

[Header("Choices Var")]
[SerializeField] private Image[] choicesSprite; 
[SerializeField] private GameObject choicesPanel;
[SerializeField] private TextMeshProUGUI[] choicesNameTxt;




[Header("Buttons")]
[SerializeField]private Button EventStart_B;
[SerializeField]private GameObject NextScene_B;
[SerializeField]private Button Next_choices_B;


[Header("Report")]
[SerializeField] private Report[] toReport;
private EmptyEvent empty;
private int localIndex = 0;
private EventData currentEvent;


[Header("result var")]
private float _crimeChange;
private string resultString;

void Start()
{
empty = GetComponent<EmptyEvent>();
LocalIndex();

}

private void LocalIndex()
    {
        while (localIndex < eventData.Length)
        {
            currentEvent = eventData[localIndex];

            if (ActiveHeroList().Count > 0)
            {
                // Proceed with event as usual if there are active heroes
               
                StartCoroutine(StartEventDelay());
                return; // Exit the loop
            }

            localIndex++; // Move to the next event index
        }

        // No events found with active heroes, activate next scene button
        if(localIndex<4){
        SetReport(localIndex, currentEvent, empty.GetSetence());
        }
        NextScene_B.SetActive(true);
        EventStart_B.interactable = false;
        Next_choices_B.interactable = false;
    }
IEnumerator StartEventDelay(){
   // Option 1: Wait for 3 seconds or space key press (more flexible)
    float timer = 3f;
    while (timer > 0f && !Input.GetKeyDown(KeyCode.Space))
    {
        timer -= Time.deltaTime;
        yield return null;
    }

    // Option 2: Wait for 3 seconds only (simpler)
    // yield return new WaitForSeconds(3f);

    EventStart();

}
public void BalloonTrigger(){
int boolCount = currentEvent.dialogCheck.Length;     
for (int i = 0; i < boolCount; i++)
{
if(currentEvent.dialogCheck[i]){
ballonObject[i].SetActive(currentEvent.dialogCheck[i]);
speechText[i].gameObject.SetActive(currentEvent.dialogCheck[i]); 
speechText[i].text = currentEvent.speechBallon[i];

}
else{
ballonObject[i].SetActive(currentEvent.dialogCheck[i]);
speechText[i].gameObject.SetActive(currentEvent.dialogCheck[i]);  
}
}      

}
public void EventStart(){
 EventStart_B.interactable = false;
 Next_choices_B.interactable = true;
 _crimeChange = 0;

BalloonTrigger();
DeactiveChoices();

// speechText[0].text = currentEvent.localIndex.ToString();
for (int i = 0; i < currentEvent.frames.Length; i++)
{        
frames[i].sprite = currentEvent.frames[i]; 
 if(i == 1)
 {
HeroeGroup(i);
 }
 
}

}

//conta o numero de heróis por evento/local
private void HeroeGroup(int index){
switch(ActiveHeroList().Count)
    {
 case 1:
frames[index].sprite = ActiveHeroList()[0].heroPose; 
 break;
 case 2:
frames[index].sprite = groupSprite[0];
 break;
 case 3:
 frames[index].sprite = groupSprite[1];
 break;
 case 4:
 frames[index].sprite = groupSprite[2];
 break;
}
}

public void DeactiveChoices(){
   
   for (int i = 0; i < choicesSprite.Length; i++)
   {
       choicesSprite[i].gameObject.SetActive(false);
   
   }
   if(choicesPanel.activeInHierarchy){
      choicesPanel.SetActive(false);
   }



}

public void ChooseSelected(int index){
Next_choices_B.interactable = false;
EventStart_B.interactable = true;
frames[4].sprite = currentEvent.eventChoices[index].chooseSprite;
DeactiveChoices();
EventResult(index);
}
public void SetChoices(){
   
if(!choicesPanel.activeInHierarchy){

   
   choicesPanel.SetActive(true);
   for (int i = 0; i < currentEvent.eventChoices.Length; i++)
   {
      choicesSprite[i].gameObject.SetActive(true);
      choicesSprite[i].sprite = currentEvent.eventChoices[i].chooseSprite;
      choicesNameTxt[i].text  = currentEvent.eventChoices[i].choose; 
   }
   }
}



#region event Result

public void EventResult(int index ){
     Sprite[] resultImage = currentEvent.resultFrame;
     

//* FIGHT OPTION
switch(currentEvent.eventChoices[index].choose ){
   case "fight":
FightOption();
   break;
   default:
 resultFrame.sprite= resultImage[2];
 resultString  = "Neutral";
 SetReport(localIndex,currentEvent,resultString);
   break;
} 

 
localIndex++;
   
if(localIndex>3 ){
   NextScene_B.SetActive(true);
   EventStart_B.interactable = false;
   return;
   }
 LocalIndex();
        }

#endregion


    //*Fight option function                      //fight option 
#region FIGHTOPTION
 private void FightOption(){

   Sprite[] resultImage = currentEvent.resultFrame;
     
   float dangerFinalValue = CrimeDataBase.instance.
   DangerValue(localIndex) * currentEvent.dangerModifier;
   float fightStrength = 0;
   


for (int i = 0; i < ActiveHeroList().Count; i++)
{
  fightStrength += ActiveHeroList()[i].power;
}

if( dangerFinalValue < fightStrength){
     resultFrame.sprite = resultImage[0];
     resultString  = "Good";
     

float dangerMulti = 0.05f * CrimeDataBase.instance.crimeData[localIndex].dangerValue;


for (int i = 0; i < ActiveHeroList().Count; i++)
{
   ActiveHeroList()[i].conditions[0] -= ActiveHeroList()[i].maxHealth * dangerMulti;;   
}

    
     EnemiesDefeat();
     SetReport(localIndex,currentEvent,resultString);
     

     //good result
    }
    if(dangerFinalValue > fightStrength){
       resultFrame.sprite = resultImage[1];
       resultString  = "Bad";
    

    

    float dangerMulti = 0.2f * CrimeDataBase.instance.crimeData[localIndex].dangerValue;
    for (int i = 0; i < ActiveHeroList().Count; i++){
     ActiveHeroList()[i].conditions[0] -= ActiveHeroList()[i].maxHealth * dangerMulti;;
    }
      EnemiesDefeat();
      SetReport(localIndex,currentEvent,resultString);
       //bad result
    }
 }

 private void EnemiesDefeat(){
   float eachEnemyPower = currentEvent. enemiesPower / currentEvent.enemiesNumber;
   float heroesTotalPower= 0;
   int enemiesDown = 0;
   
   for (int i = 0; i < ActiveHeroList().Count; i++)
   {
      heroesTotalPower += ActiveHeroList()[i].power; 
   }
   for (int i = 0; i < currentEvent.enemiesNumber; i++)
   {
      if(heroesTotalPower>eachEnemyPower){
      heroesTotalPower -= eachEnemyPower;
      _crimeChange += eachEnemyPower / 2;
      enemiesDown ++;
      }

   }

  currentEvent.enemiesDefeated = enemiesDown;
 }

 #endregion FIGHTOPTION

    //*Set report  //set report // set report // set report

     private void SetReport(int index,EventData _currentEvent,string result){
     toReport[index].enemiesDefeated = currentEvent.enemiesDefeated;
     toReport[index].enemiesNumber = _currentEvent.enemiesNumber;
   
     toReport[index].crimeChange = _crimeChange;
     toReport[index].result  = result;
     toReport[index].heroesReport = ActiveHeroList();

     ReportPersistance.Instance.SetReport(toReport[index]);
     
     }
     public List<HeroData> ActiveHeroList(){
        switch(localIndex){  
           case 1: 
           return HeroInAction.Instance.heroInAction1; 
           case 2:
           return HeroInAction.Instance.heroInAction2;          
           case 3: 
           return HeroInAction.Instance.heroInAction3; 
           default:
           return HeroInAction.Instance.heroInAction0;
        }
     } 

     
}
