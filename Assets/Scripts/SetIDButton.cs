using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetIDButton : MonoBehaviour
{
   [SerializeField ] private int Id;
   [SerializeField] private SlotSelect[] slots;
   private TextMeshProUGUI heroNameText;

   
   void Start()
   {
heroNameText = GetComponentInChildren<TextMeshProUGUI>();
 if(HeroPersistance.Instance.myHeros.Count>Id){
heroNameText.text = HeroPersistance.Instance.myHeros[Id].heroName;
      }
    for (int i = 0; i < slots.Length; i++)
    {
      slots[i].SlotSelected += ButtonActiveHandler;
       slots[i].SlotCleared += ButtonDeactiveHandler;
    }   
   }


   void ButtonActiveHandler(int index){
       if(index == Id){
         gameObject.GetComponent<Button>().interactable = false;
       }
   }
    void ButtonDeactiveHandler(int index){
      if(index == Id){
         gameObject.GetComponent<Button>().interactable = true;
       }
    }
   public void Set(){
   ActiveID.ID = Id;

   Debug.Log($"static id : {ActiveID.ID}");
   }
}
