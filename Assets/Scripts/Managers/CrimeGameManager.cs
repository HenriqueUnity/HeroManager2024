using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CrimeGameManager : MonoBehaviour
{
   [SerializeField] private SpriteInteraction[] localsTrigger;
   
   [SerializeField] private LocalCrime[] locals;
   [SerializeField] private LocalPanel[] localPanel;
   [SerializeField] private GameObject[] readyMessages;
   [SerializeField] private SetSlot[] setSlotEvent;
   [SerializeField] private SlotSelect[] slots;
   [SerializeField] private SlotSelect[] slots1;
   [SerializeField] private SlotSelect[] slots2;
   [SerializeField] private SlotSelect[] slots3;
  // private int slotPaneltoClose =0;
   [SerializeField] private GameObject panel;

   
   private int _index = 0;
    void Start()
    {
      
   panel.SetActive(false);
   ActiveID.ID = 99;
   
    

    //ready messages to close
    for (int i = 0; i < slots.Length; i++)
    {
      slots[i].SlotCleared+= ReadyMessageClose;      
    }

        for (int i = 0; i < slots1.Length; i++)
    {
      slots1[i].SlotCleared+= ReadyMessageClose1;      
    }
    for (int i = 0; i < slots2.Length; i++)
    {
      slots2[i].SlotCleared+= ReadyMessageClose2;      
    }
    for (int i = 0; i < slots3.Length; i++)
    {
      slots3[i].SlotCleared+= ReadyMessageClose3;      
    }
    ///////

      //setar valores nas abas
   for (int i = 0; i < locals.Length; i++)
   {
    locals[i].SettedCrimeData += SetData;
   }
   

   //abrir abas
   for (int i = 0; i < localsTrigger.Length; i++)
   {
    localsTrigger[i].popUp += OpenTab;
   }
   

   //abrir mensagem de pronto
   for (int i = 0; i < setSlotEvent.Length; i++)
   {
    setSlotEvent[i].HeroSetted +=  ReadyMessage;
   }
    
    
    }
    private void ReadyMessage(int localIndex,HeroData heroNull){
      readyMessages[localIndex].SetActive(true);
    }
    private void ReadyMessageClose(int indexNull){
      readyMessages[0].SetActive(false);
    }
     private void ReadyMessageClose1(int indexNull){
      readyMessages[1].SetActive(false);
    }
     private void ReadyMessageClose2(int indexNull){
      readyMessages[2].SetActive(false);
    }
     private void ReadyMessageClose3(int indexNull){
      readyMessages[3].SetActive(false);
    }
    private void SetData(CrimeData data){
     localPanel[_index].GetData(data);
     
    }
   
   
    private void OpenTab(int index){
      _index = index;
      localPanel[index].gameObject.SetActive(true);

    }
}
