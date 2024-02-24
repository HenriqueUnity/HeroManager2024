using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotSelect : MonoBehaviour
{
    private int index;
    private int clearIndex;
    [SerializeField] private int id;
    private bool slotActive;
    //public Action<int> SlotSelected;
    public delegate void Select(int index);
    public Select SlotSelected;
    public Select SlotCleared;
        public void SetHero(){
        index= ActiveID.ID;
        Debug.Log(index);


        if(!slotActive){
         slotActive = true; 
         SlotSelected?.Invoke(index); 
         clearIndex = index;          
        }else{
         slotActive = false;
         SlotCleared?.Invoke(clearIndex);
        }


       
        Debug.Log($" {slotActive} slot :{id} index:{index}");
    }

 
}
