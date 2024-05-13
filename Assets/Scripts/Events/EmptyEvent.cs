using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyEvent : MonoBehaviour
{
    //[SerializeField] private EventData baseEvent;
    [SerializeField] private string[] sentences ; 
     

    // public EventData GetEmptyReportData(){
    //      return baseEvent;
    // }
   
   void Start()
   {
       sentences = new string[5];
       sentences[0] = "All that is necessary for the triumph of evil is that good men do nothing.";
       sentences[1] = "The only thing necessary for the triumph of evil is that good people do nothing.";
       sentences[2] = "Evil will triumph if good people do nothing.";
       sentences[3] = "O homem superior age sem pensar nas consequências; o homem comum pensa nas consequências, mas não age.";
       sentences[4] = "Quão maravilhoso é que ninguém precise esperar um único momento para começar a melhorar o mundo!";
   }
    public string GetSetence(){
        int randomIndex = Random.Range(0,4);
       return sentences[randomIndex];
    }
}
