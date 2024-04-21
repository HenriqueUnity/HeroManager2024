using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugDict : MonoBehaviour
{
   [SerializeField]private TextMeshProUGUI debugText;


public void DebugIndex(int index){
    debugText.text = HeroInAction.
    Instance.heroInAction0[0].heroName;
}
}
