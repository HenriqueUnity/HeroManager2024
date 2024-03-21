
using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
[CreateAssetMenu(fileName = "Data", menuName = "HeroData/NewHeroData")]
public class HeroData : ScriptableObject
{
   //public int ID; 
  public string heroName;
   public float power;
   public float fame;
   public float value;
   public Sprite spritePortrait;
   public List <string> traits ;
   public List <float> conditions ;
   

   
   public HeroData(string heroName, float power, float fame, float value, List<string> traits, List<float> conditions, Sprite portrait) 
    {
        this.heroName = heroName;
        this.power = power;
        this.fame = fame;
        this.value = value;
        this.traits = traits;
        this.conditions = conditions;
        this.spritePortrait = portrait; 
    }
   
   
   
}
