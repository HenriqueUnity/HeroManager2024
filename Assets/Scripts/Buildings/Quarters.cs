using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Quarters : MonoBehaviour
{
   [SerializeField] private GameObject[] heroesSlots;
   [SerializeField] private TextMeshProUGUI nameText;
   [SerializeField] private TextMeshProUGUI healthText;
   [SerializeField] private TextMeshProUGUI humorText;
   [SerializeField] private TextMeshProUGUI hapinessText;

   [SerializeField]private IDscript[] idScript;
   private int heroCount;
   
    void Start()
    {
   //   idScript = new IDscript[13];
        QuarterHeroes();
        for (int i = 0; i < idScript.Length; i++)
        {
          idScript[i].SettedId += OnSetID;
        }
    }

  public void QuarterHeroes(){
    heroCount = HeroPersistance.Instance.myHeros.Count;
    for (int i = 0; i < heroCount; i++)
    {
        heroesSlots[i].SetActive(true);
      // Button slotButton = heroesSlots[i].GetComponent<Button>();
      
       idScript[i].ID = i;
      // slotButton.onClick.AddListener(delegate{idScript.Debug1();});
    }
  }
  
  private void OnSetID(int id){
    HeroData heroStats = HeroPersistance.Instance.myHeros[id];
    nameText.text = heroStats.heroName;
    healthText.text = heroStats.conditions[0].ToString();
    humorText.text =heroStats.conditions[1].ToString();
    hapinessText.text = heroStats.conditions[2].ToString();
  }
  }

