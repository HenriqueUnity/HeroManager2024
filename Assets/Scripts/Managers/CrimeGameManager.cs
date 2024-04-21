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
   [SerializeField] private TextMeshProUGUI debugText;

   private bool[] readyBools = {false,false,false,false};
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
   
#region setSlot
   //abrir mensagem de pronto
   for (int i = 0; i < setSlotEvent.Length; i++)
   {
    setSlotEvent[i].HeroSetted +=  ReadyMessage;
   }

  
    HeroInAction.Instance.localSetSlot = setSlotEvent;
    HeroInAction.Instance.SetButtons();
   
 #endregion   
    
    }
    private void ReadyMessage(int localIndex,HeroData heroNull){
      readyMessages[localIndex].SetActive(true);
      readyBools[localIndex] = true;
      AllReady();
    }
    private void ReadyMessageClose(int indexNull){
      readyMessages[0].SetActive(false);
      readyBools[0] = false;
       AllReady();
    }
     private void ReadyMessageClose1(int indexNull){
      readyMessages[1].SetActive(false);
      readyBools[1] = false;
       AllReady();
    }
     private void ReadyMessageClose2(int indexNull){
      readyMessages[2].SetActive(false);
      readyBools[2] = false;
       AllReady();
    }
     private void ReadyMessageClose3(int indexNull){
      readyMessages[3].SetActive(false);
      readyBools[3] = false;
       AllReady();

    }
    private void SetData(CrimeData data){
     localPanel[_index].GetData(data);
     
    }

    ///checar se todos readymessagem estao ativos na cena
    private void AllReady(){
     for (int i = 0; i < readyBools.Length; i++)
     {
      if(readyBools[i]){
        Debug.Log("ready");
      }else{
        debugText.text = "not ready";
        return;
      }
      Debug.Log("all ready");
       debugText.text = "all ready";
     }
    }
   
    private void OpenTab(int index){
      _index = index;
      localPanel[index].gameObject.SetActive(true);

    }
}
