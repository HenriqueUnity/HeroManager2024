using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReadHero : MonoBehaviour
{
   private HeroPersistance heroData;
   private List<HeroData> heroes;
   
   [SerializeField] private TextMeshProUGUI[] nameText;
   [SerializeField] private TextMeshProUGUI[] powerText;
    void Start()
    {
        heroData = FindObjectOfType<HeroPersistance>();
        heroes = heroData.myHeros;
    }

    

   public void ReadHeroInfo(){
    for (int i = 0; i < heroes.Count; i++)
    {
        nameText[i].text = heroes[i].heroName;
        powerText[i].text = heroes[i].power.ToString();
    }
   }
    
}
