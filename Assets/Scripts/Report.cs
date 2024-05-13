
using System;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
[CreateAssetMenu(fileName = "Data", menuName = "ReportData/Report")]
public class Report : ScriptableObject
{
   public int localIndex;
   public string result;

   [Header("enemies Info")]
   public int enemiesNumber;
   public int enemiesDefeated;

   [Header("enemies Info")]
   public int innocentNumber;
   public int innocentRescued;

   [Header("modifiers info")]     
   public float dangerModifier;
   

   [Header("crime changes")]
   public float crimeChange;
   public float crimeLordAttention;

   [Header("Heroes info")]
   public List<HeroData> heroesReport;
   public float lifeLoss;
   public float fameChange;   
   public float fadigueChange;

   
}


