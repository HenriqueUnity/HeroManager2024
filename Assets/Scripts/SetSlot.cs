using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSlot : MonoBehaviour
{
    [SerializeField] private SlotSelect[] slots;
    [SerializeField] private int localIndex;
    
    
    private List<HeroData> heroesSetted = new();
    public delegate void HeroSet(int index,HeroData hero);
    public event HeroSet HeroSetted;
    void Start()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].SlotSelected += HeroSlot;
            slots[i].SlotCleared += UnSetSlot;
        }
    }

    private void UnSetSlot(int index){


      HeroData hero = HeroPersistance.Instance.myHeros[index];
      switch (localIndex)
    {
        case 0:
        HeroInAction.Instance.heroInAction0.Remove(hero);
        
        break; 
        case 1:
        HeroInAction.Instance.heroInAction1.Remove(hero);
        
        break;
        case 2:
        HeroInAction.Instance.heroInAction2.Remove(hero);

        break; 
        case 3:
        HeroInAction.Instance.heroInAction3.Remove(hero);
        break;
    }
     Debug.Log($"removed {HeroPersistance.Instance.myHeros[index].heroName}");
     heroesSetted.Remove(HeroPersistance.Instance.myHeros[index]);
    }
   void HeroSlot(int index){
 heroesSetted.Add(HeroPersistance.Instance.myHeros[index]);
 Debug.Log($"added hero {HeroPersistance.Instance.myHeros[index].heroName}");
   }

   public void SetHeroes(){
    
  if(heroesSetted.Count>0){
    for (int i = 0; i < heroesSetted.Count; i++)
    {
        Debug.Log(heroesSetted[i].heroName) ;
        HeroSetted?.Invoke(localIndex,heroesSetted[i]);
    }

  }
   }
}
