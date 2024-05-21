using UnityEngine;

public class GameManager : MonoBehaviour
{  
    [SerializeField] private Quarters headQuarters;
    [SerializeField ]private ShopElements[] shopElements;

    [Header("Panels")]
    [SerializeField] private GameObject agencyPanel;   
    [SerializeField] private GameObject headQuartersPanel;
    
    [Header("Triggers")]
    [SerializeField] private ClickHandler[] clickHandler;
  
    void Start()
    {             
        //agency.popUp += OpenTab;
       
      DayManager.instance.SetText();
      
    
      for (int i = 0; i < clickHandler.Length; i++)
      {
        
      clickHandler[i].TriggerHandlerActive += GetClickHandler;
      }
     }
 
    void GetClickHandler(string nameRef){

       switch(nameRef){
        case "hq":
        OpenHeadQuartersPanel();
        break;
        case "agency":
        StartAgencyPanel();
        break;
       }
        return;
    
    }
    void StartAgencyPanel(){
     //   shopElements = FindObjectsOfType<ShopElements>();
     agencyPanel.SetActive(true);
       for (int i = 0; i < shopElements.Length; i++)
        {
            shopElements[i].ChoosedHero += OnChooseHero;

        }
    }

    void OpenHeadQuartersPanel(){
      headQuartersPanel.SetActive(true);
      headQuarters.QuarterHeroes();
    }

   
    void OnChooseHero(HeroData hero){        

        HeroPersistance.Instance.myHeros.Add(hero);    
    }
}
