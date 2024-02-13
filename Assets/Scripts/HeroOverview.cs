using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class HeroOverview : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI heroName;
    [SerializeField] private TextMeshProUGUI[] atributes;
    [SerializeField] private TextMeshProUGUI[] traits;
    [SerializeField] private TextMeshProUGUI[] conditions;

     private HeroData heroData;
    private HeroPersistance _instance;
    void Start()
    {
        _instance =  HeroPersistance.Instance;
        ReadHeroData(0);
    }

    // Update is called once per frame
   public void ReadHeroData(int index){

    heroData = _instance.myHeros[index];
    heroName.text = heroData.heroName;
    atributes[0].text = heroData.power.ToString();
    atributes[1].text = heroData.fame.ToString();
    atributes[2].text = heroData.value.ToString();

    for (int i = 0; i < heroData.traits.Count; i++)
    {
        traits[i].text = heroData.traits[i];
    }

    for (int i = 0; i < heroData.conditions.Count; i++)
    {
         conditions[i].text = heroData.conditions[i].ToString();
    }

   }
}
