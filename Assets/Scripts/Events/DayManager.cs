using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DayManager : MonoBehaviour
{
    public static DayManager instance;
    public int dayCount = 1;
    public string[] dayWeek = {"Seg","Ter","Qua","Qui","Sex","Sab","Dom"};
    private int dayWeekIndex = 0;
    public bool daylight = true;

     private TextMeshProUGUI weekTxt,dayCountTxt,daylightTxt;

     
     public static DayManager Instance
    {
        get
        {
            if (instance == null)
            {
            
                // Se a instância ainda não foi criada, tenta encontrá-la na cena
                instance = FindObjectOfType<DayManager>();

                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("DayManager");
                    instance = singletonObject.AddComponent<DayManager>();
                }
                // Garante que a instância persista entre as cenas
                Debug.Log("Instance HeronInAction created");
            }

            return instance;
        }
    }
     void Awake()
     {

       if (instance != null && instance != this)
        {
            Destroy(this);
        }else{
            DontDestroyOnLoad(this);
            instance = this;           
        }         
     }
    void Start()
    {      
      
       SetText();
      
    }

public void SetText(){
GetRef();
dayCountTxt.text = $"Dia: {dayCount}";
weekTxt.text = dayWeek[dayWeekIndex];
DayTime();

}
 private void GetRef(){
    try
    {
    dayCountTxt = GameObject.Find("dayCount").GetComponent<TextMeshProUGUI>();
    weekTxt = GameObject.Find("weekDay").GetComponent<TextMeshProUGUI>();
    daylightTxt= GameObject.Find("dayTime").GetComponent<TextMeshProUGUI>();        
    }
    catch (System.Exception)
    {
      Debug.Log("Fora da mainScene");  
    }
 }
  public void PassDay(){
        dayCount++;
        dayWeekIndex++;
        if(dayWeekIndex>6){
            dayWeekIndex = 0;
        }
         weekTxt.text = dayWeek[dayWeekIndex];
         daylight = true;
         SetText();
    }
   public void PassReport(){
    if(!daylight){
        PassDay();
    }else{
        daylight= false;
        SetText();
        
    }

   } 

public void DayTime(){
if(daylight){
daylightTxt.text = "Dia";
}
else
{
daylightTxt.text = "Noite";
}
   } 

public void OnSceneLoaded(Scene scene,LoadSceneMode mode){
    PassReport();
    SceneManager.sceneLoaded -= OnSceneLoaded;
}
 
}
