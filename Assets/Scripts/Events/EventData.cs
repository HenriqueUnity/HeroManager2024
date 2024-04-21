
using UnityEngine;
using UnityEngine.UI;
using System;
[Serializable]
[CreateAssetMenu(fileName = "Data", menuName = "EventData/NewEventData")]
public class EventData : ScriptableObject
{
   public int localIndex;
   public Sprite[] frames;
   public bool[] dialogCheck;
   public string[] speechBallon;
   public Sprite[] resultFrame;
   //resultframe0 = good
    //resultframe1 = bad
     //resultframe2 = neutral
}
