using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDscript : MonoBehaviour
{
    public int ID;
    public  delegate void SetId(int id);
    public event SetId SettedId;
   public void IDSet(){
    SettedId?.Invoke(ID);
   }
  
  
  
}
