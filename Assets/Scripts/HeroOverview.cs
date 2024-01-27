using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class HeroOverview : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI heroName;
    [SerializeField] private TextMeshProUGUI[] atributes;
    [SerializeField] private TextMeshProUGUI[] traits;
    [SerializeField] private TextMeshProUGUI[] conditions;

    [SerializeField] private HeroData heroData;
    void Start()
    {
        ReadHeroData();
    }

    // Update is called once per frame
   public void ReadHeroData(){

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
