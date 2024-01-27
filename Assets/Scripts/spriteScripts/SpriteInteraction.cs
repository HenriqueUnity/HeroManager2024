using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteInteraction : MonoBehaviour
{
    public delegate void PopUp();
    public PopUp popUp;
  
   
   public void OnMouseDown()
    {
      popUp?.Invoke();
    }
  
    
}
