
using UnityEngine;
using UnityEngine.UI;
using System;
[Serializable]
[CreateAssetMenu(fileName = "Data", menuName = "EventData/NewEventData")]
public class EventData : ScriptableObject
{
   public Sprite[] frames;
   public bool[] dialogCheck;
   public string[] speechBallon;
   public Sprite[] resultFrame;
   //resultframe0 = good
    //resultframe0 = bad
     //resultframe0 = neutral
}
