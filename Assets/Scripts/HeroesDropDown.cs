using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class HeroesDropDown : MonoBehaviour
{

    [SerializeField] private List<HeroData> myHeroes;    
    [SerializeField] private GameObject[] heroOptions;
    
    
 
    void Start()
    { 
      for (int i = 0; i < heroOptions.Length; i++)
      {
         if(heroOptions[i].activeInHierarchy){
            heroOptions[i].SetActive(false);
         }
      }
           gameObject.SetActive(false);
      
    }

   public void DropDownStart(){
    if(gameObject.activeInHierarchy){
      gameObject.SetActive(false);
      return;
    } else{
      gameObject.SetActive(true);
    } 
    myHeroes = HeroPersistance.Instance.myHeros; 
    Debug.Log(myHeroes.Count);
   
    
    for (int i = 0; i < myHeroes.Count; i++)
    {
      heroOptions[i].SetActive(true);
    }
   }
}

