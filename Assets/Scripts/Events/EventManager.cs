using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{

    private HeroData[] heroInAction; 
    [SerializeField] private EventData eventData;
    [SerializeField] private GameObject[] ballonObject;
    [SerializeField] private TextMeshProUGUI[] speechText;
    [SerializeField] private Image[] frames;
    [SerializeField] private Image resultFrame;
    void Start()
    {
        
    }

    public void BalloonTrigger(){
     int boolCount = eventData.dialogCheck.Length;
     
     for (int i = 0; i < boolCount; i++)
     {
     frames[i].sprite = eventData.frames[i]; 
     ballonObject[i].SetActive(eventData.dialogCheck[i]);
     speechText[i].text = eventData.speechBallon[i];
     } 
     

    }

    public void EventResult(string result){
     Sprite[] resultImage = eventData.resultFrame;
    if(result == "good"){
     resultFrame.sprite = resultImage[0];
    }
    if(result == "bad"){
       resultFrame.sprite = resultImage[1];
    }
    if(result== "neutral"){
     resultFrame.sprite = resultImage[2];
    } 
    }
  
}
