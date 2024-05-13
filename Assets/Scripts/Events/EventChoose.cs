using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "ChooseData", menuName = "EventData/EventChoose")]
public class EventChoose : ScriptableObject
{
   public string choose;
   public Sprite chooseSprite;
}
