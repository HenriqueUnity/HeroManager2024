using UnityEngine;

public class AvailableControl : MonoBehaviour
{
   private float defaultPercenteValue = 0.25f;
 

    public bool AvailableCheck(HeroData hero){
      
       float minimumHealth =  hero.maxHealth *defaultPercenteValue;

      if(hero.conditions[0]<= minimumHealth || hero.conditions[1] == 0){

        return false;
      }
       for (int i = 0; i < hero.traits.Count; i++)
       {        
      switch(hero.traits[i])
      {
        case "Noturno":
        if(DayManager.Instance.daylight){
            return false;
        }else
        return true;
        case "Diurno":
          if(!DayManager.Instance.daylight){
            return false;
        }else
        return true;
        
        ;
      };
       }
    
      
      return true;
    }
}
//conditions[0] = health
//conditions[1] = fadigue
//conditions[2] = humor