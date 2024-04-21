using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HeroOverview : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI heroName;
    [SerializeField] private TextMeshProUGUI[] atributes;
    [SerializeField] private TextMeshProUGUI[] traits;
    [SerializeField] private TextMeshProUGUI[] conditions;
    [SerializeField] private Image fullPortrait;

    private int maxTraits = 10;
    private int indexF = 0;
    private HeroData heroData;
    //private HeroPersistance _instance;
    void Start()
    {
        //_instance =  HeroPersistance.Instance;
        
        ReadHeroData(indexF);
        
    }
    
    

    // Update is called once per frame
   public void ReadHeroData(int index){

    heroData = HeroPersistance.Instance.myHeros[index];
    HideTraits();
    heroName.text = heroData.heroName;
    atributes[0].text = heroData.power.ToString();
    atributes[1].text = heroData.fame.ToString();
    atributes[2].text = heroData.value.ToString();
    fullPortrait.sprite = heroData.heroImage;

    for (int i = 0; i < heroData.traits.Count; i++)
    {
        traits[i].text = heroData.traits[i];
    }

    for (int i = 0; i < heroData.conditions.Count; i++)
    {
         conditions[i].text = heroData.conditions[i].ToString();
    }

   }
   private void HideTraits(){
    int heroTraits = heroData.traits.Count;
    for (int i = 0; i < heroTraits; i++)
    {
        traits[i].gameObject.SetActive(true);
    }
    for (int i = heroTraits; i < maxTraits; i++)
    {
        traits[i].gameObject.SetActive(false);
    }
   }
}
