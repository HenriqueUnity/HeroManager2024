using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public HeroData heroData;
    public string _heroName;
   [Header("atributes")]
   public float _power;
   public float _fame;
   public float _value;

   
   public List <string> _traits ;
   public List <float> _conditions ;
   
   [Header("Sprites")]
   public Sprite _spritePortrait;
   public Sprite _heroImage;
   public Sprite _heroPose;



   public float percentHealthValue = 0.25f; 
    void Start()
    {
       _heroName = heroData.heroName;
       _power = heroData.power;
       _fame = heroData.fame;
       _value = heroData.value;
       _traits = heroData.traits;
       _conditions = heroData.conditions;
       _spritePortrait = heroData.spritePortrait;
       _heroImage = heroData.heroImage;
       _heroPose   = heroData.heroPose;



       percentHealthValue = _conditions[0] * percentHealthValue; 
    }

    public bool AvailableCheck(){           
      if(_conditions[0]>percentHealthValue){//health
       
        return false;
      }
      if(_conditions[1]<=0){//fadigue
        return false;
      }  
      return true;
      
    }
    
}
//0 = health
//1 = fadigue 
//2 = humor