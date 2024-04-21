using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.CompilerServices;
using TMPro;
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


[Header("Buttons")]
[SerializeField]private Button EventStart_B;
[SerializeField]private Button NextScene_B;

private int localIndex = 0;
private EventData currentEvent;
void Start()
{
LocalIndex();
EventStart();
}
private void LocalIndex(){
for (int i = 0; i < eventData.Length; i++)
{
if(localIndex == i){
currentEvent = eventData[i];

return;
} 
if(ActiveHeroList().Count==0){
Debug.Log("area sem herois");
EventStart_B.interactable= false;
NextScene_B.interactable = true;
}
}
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

BalloonTrigger();
// speechText[0].text = currentEvent.localIndex.ToString();
for (int i = 0; i < currentEvent.frames.Length; i++)
{        
frames[i].sprite = currentEvent.frames[i]; 
 if(i == 1)
 {
switch(ActiveHeroList().Count)
    {
 case 1:
frames[i].sprite = ActiveHeroList()[0].heroPose; 
 break;
 case 2:
frames[i].sprite = groupSprite[0];
 break;
 case 3:
 frames[i].sprite = groupSprite[1];
 break;
 case 4:
 frames[i].sprite = groupSprite[2];
 break;
          //[0] = 2 hero silhoute
          //[1] = 3 hero silhoute
          //[2] = 4 hero silhoute
     }
 }
 
}
}

    public void EventResult( ){
     Sprite[] resultImage = currentEvent.resultFrame;
if( CrimeDataBase.instance.
DangerValue(localIndex)<ActiveHeroList()[0].power){
     resultFrame.sprite = resultImage[0];
     //good result
    }
    if(CrimeDataBase.instance.
DangerValue(localIndex)>ActiveHeroList()[0].power){
       resultFrame.sprite = resultImage[1];
       //bad result
    }
   if(CrimeDataBase.instance.
DangerValue(localIndex)==ActiveHeroList()[0].power){
     resultFrame.sprite= resultImage[2];
     //neutral result
    } 

    //result = resultFrame;
    localIndex++;
        LocalIndex();
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
