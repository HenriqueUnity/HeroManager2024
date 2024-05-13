
using UnityEngine;
using UnityEngine.UI;
using System;
[Serializable]
[CreateAssetMenu(fileName = "Data", menuName = "EventData/NewEventData")]
public class EventData : ScriptableObject
{
   public int localIndex;
   public int enemiesNumber;
   public int innocentNumber;
   public float fameModifier;   
   public float dangerModifier;
   public Sprite[] frames;
   public bool[] dialogCheck;
   public string[] speechBallon;

   public EventChoose[] eventChoices;
   public Sprite[] resultFrame;
   //resultframe0 = good
    //resultframe1 = bad
     //resultframe2 = neutral
}
