using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class HeroesDropDown : MonoBehaviour
{

    [SerializeField] private List<HeroData> myHeroes;
    [SerializeField] private Sprite defaultImage;
    [SerializeField] private GameObject[] HeroOptions;
    private Dictionary<int,HeroData> heroButton = new();
    public UnityEvent<HeroData> HeroEvent = new UnityEvent<HeroData>();
    
    void Start()
    { 
    

       DropDownIntance();
    }

    public void DropDownIntance(){
     
       for (int i = 0; i < myHeroes.Count; i++)
       {
        HeroEvent.AddListener(MyEventHandler);
        HeroOptions[i].SetActive(true);
        heroButton[i] = myHeroes[i];
         HeroEvent.Invoke(heroButton[i]);
        
        
       }
     
       
    }
    void MyEventHandler(HeroData hero)
    {
        Debug.Log(hero.heroName);
    }
    
}

