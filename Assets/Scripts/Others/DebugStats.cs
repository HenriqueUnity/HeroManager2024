using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugStats : MonoBehaviour
{
  [SerializeField] private GameObject debugPanel;
 
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)){
            if(debugPanel.activeInHierarchy){
                debugPanel.SetActive(false);
            }else{
                 debugPanel.SetActive(true);
            }
        }
    }
}
