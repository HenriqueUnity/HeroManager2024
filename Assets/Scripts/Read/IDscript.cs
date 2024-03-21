using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDscript : MonoBehaviour
{
    public int ID;
    public  delegate void SetId(int id);
    public event SetId SettedId;
    private Image portrait;
   public void IDSet(){
    SettedId?.Invoke(ID);
   }
  
 
  void Start()
  {
      portrait = GetComponent<Image>();
      portrait.sprite = HeroPersistance.Instance.myHeros[ID].spritePortrait;
  }
  
}
