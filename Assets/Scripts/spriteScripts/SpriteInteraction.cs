using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteInteraction : MonoBehaviour
{
    public delegate void PopUp(int index);
    public  PopUp popUp;
    [SerializeField]private int index;
   
   public void OnMouseDown()
    {
      popUp?.Invoke(index);
    }
  
    
}
