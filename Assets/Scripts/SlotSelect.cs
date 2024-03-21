using UnityEngine;
using UnityEngine.UI;
using System;
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
    private Image portraitActive;
    [SerializeField] private Sprite defaultSprite;
      
      
      void Start()
      {
          portraitActive = GetComponent<Image>();
          portraitActive.sprite = defaultSprite;
          
      }
        public void SetHero(){
        index= ActiveID.ID;
        Debug.Log(index);

 try{

    if(!slotActive){
         slotActive = true; 
         SlotSelected?.Invoke(index); 
         portraitActive.sprite = HeroPersistance.Instance.myHeros[index].spritePortrait;
         clearIndex = index;          
    }else{
         slotActive = false;
         portraitActive.sprite = defaultSprite;
         SlotCleared?.Invoke(clearIndex);
        }
      }
catch (Exception e)
    {
  Debug.Log(e.Message);
    }


        ActiveID.ID = 99;
        Debug.Log($" {slotActive} slot :{id} index:{index}");
    }

 
}
