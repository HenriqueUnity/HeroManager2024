using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReportManager : MonoBehaviour
{
private DayAction dayActionButton;
private DayManager dayManager;
    

void Start()
    {
dayActionButton = GameObject.Find("ButtonAction").
GetComponent<DayAction>();
dayManager = DayManager.instance;

 dayActionButton.DayButtonClicked += SetAction;

    }
private void SetAction(){
SceneManager.sceneLoaded += dayManager.OnSceneLoaded;
}
  
}
