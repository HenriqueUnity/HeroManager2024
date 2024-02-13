using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cheats : MonoBehaviour
{

   private bool console;
   [SerializeField] private GameObject consolePanel;
   [SerializeField] private TMP_InputField inputField;
   
    void Update()
    {
      
      if(Input.GetKeyDown(KeyCode.F2)){
        if(!consolePanel.activeInHierarchy ){
            console = true;
            consolePanel.SetActive(true); 
            inputField.Select();}
          else if (consolePanel.activeInHierarchy){
            console = false;
            consolePanel.SetActive(false);     
          }
      }









      if(Input.GetKeyDown(KeyCode.Space)){
        if(console){
         string command = inputField.text;
         if(command == "gredisgood"){
             PlayerResource.Instance.money += 1000;
             Debug.Log("console command active:"+ command);
             PlayerResource.Instance.UpdateAmount();
             
         }else{
             Debug.Log("unknow command");
         } 
         inputField.text= "";
        }
      }
    }
    
}
