using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
     public  delegate void TriggerHandler(string nameRef);
     public  event TriggerHandler TriggerHandlerActive; 
     [SerializeField] private string nameReference;
    void OnMouseDown()
    {
        TriggerHandlerActive?.Invoke(nameReference);
    }
}
