using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LocalPanel : MonoBehaviour
{
    [SerializeField] private GameObject[] slots;
    private CrimeData crimeData;
    [SerializeField] private TextMeshProUGUI localNameTitle;
    void Start()
    {
        
    }

   
    public void GetData(CrimeData data){
    crimeData = data;
    SetSlots();
    SetAllText();
    }
    private void SetAllText(){
        localNameTitle.text = crimeData.localName;
    }
    private void SetSlots(){
     int slotsAmount = crimeData.operationSlot;
     
     for (int i = 0; i < slotsAmount; i++)
     {
        slots[i].SetActive(true);
            }
    }
    public void DeactiveSlots(){
         for (int i = 0; i < slots.Length; i++)
     {
        slots[i].SetActive(false);
     }
    }
    
}

