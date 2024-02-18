using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CrimeGameManager : MonoBehaviour
{
   [SerializeField] private SpriteInteraction[] localsTrigger;
   
   [SerializeField] private LocalCrime[] locals;
   [SerializeField] private LocalPanel localPanel;
    
    void Start()
    {
   
   for (int i = 0; i < locals.Length; i++)
   {
    locals[i].SettedCrimeData += SetData;
   }
   
   for (int i = 0; i < localsTrigger.Length; i++)
   {
    localsTrigger[i].popUp += OpenTab;
   }
    
    
    }

    private void SetData(CrimeData data){
     localPanel.GetData(data);
    }

   
   
    private void OpenTab(){
      localPanel.gameObject.SetActive(true);
    }
}
