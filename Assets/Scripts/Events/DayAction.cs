using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAction : MonoBehaviour
{
    public Action DayButtonClicked;
    public void FinishReport(){
        DayButtonClicked?.Invoke();
    }
}
