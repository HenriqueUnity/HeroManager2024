using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
   [SerializeField] private string sceneName;
   
 

 public void ChangeScene(){
    SceneManager.LoadScene(sceneName);
 }

 public void FinishActionScene(){
   DayManager.instance.PassReport();
    SceneManager.LoadScene(sceneName);
 }
}
