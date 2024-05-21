
using UnityEngine;
using UnityEngine.UI;
using System;
[Serializable]
[CreateAssetMenu(fileName = "Data", menuName = "EventData/NewEventData")]
public class EventData : ScriptableObject
{
   public int localIndex;

   [Header("Enemies")]
   public int enemiesNumber;
   public int enemiesDefeated;
   public float enemiesPower;
   
   
   [Header("modifier")]
   public float fameModifier;   
   public float dangerModifier;

   [Header("others")]
   public Sprite[] frames;
   public bool[] dialogCheck;
   public string[] speechBallon;

   public EventChoose[] eventChoices;
   public Sprite[] resultFrame;
   //resultframe0 = good
    //resultframe1 = bad
     //resultframe2 = neutral
}
