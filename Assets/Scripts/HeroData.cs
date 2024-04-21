
using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
[CreateAssetMenu(fileName = "Data", menuName = "HeroData/NewHeroData")]
public class HeroData : ScriptableObject
{
   //public int ID; 
   public string heroName;
   [Header("atributes")]
   public float power;
   public float fame;
   public float value;

   
   public List <string> traits ;
   public List <float> conditions ;
   
   [Header("Sprites")]
   public Sprite spritePortrait;
   public Sprite heroImage;
   public Sprite heroPose;

   
   public HeroData(string heroName, float power, float fame, float value, List<string> traits, List<float> conditions, Sprite portrait,Sprite heroImage , Sprite pose) 
    {
        this.heroName = heroName;
        this.power = power;
        this.fame = fame;
        this.value = value;
        this.traits = traits;
        this.conditions = conditions;
        this.spritePortrait = portrait; 
        this.heroImage = heroImage;
        this.heroPose = pose;
    }
   
//    public Hero ToHero(){
      
//         Hero hero = gameObject.AddComponent<Hero>();
//         {
//             _heroName = heroName,
//             _power = power,
//             _fame = fame,
//             _value = value,
//             _traits = traits,
//             _conditions = conditions,
//             _spritePortrait = spritePortrait,
//             _heroImage = heroImage,
//             _heroPose = heroPose
//         };

//         return hero;
//    }
   
}
