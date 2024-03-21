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
