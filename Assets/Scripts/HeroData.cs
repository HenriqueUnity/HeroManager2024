
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "HeroData/NewHeroData")]
public class HeroData : ScriptableObject
{
   //public int ID; 
   public string heroName;
   public float power;
   public float fame;
   public float value;
   public List <string> traits = new ();
   public List <float> conditions = new();


   
   
   
}
