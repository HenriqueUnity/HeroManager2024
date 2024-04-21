using UnityEngine;

public class GameManager : MonoBehaviour
{  
    [SerializeField] private GameObject buildingPanel;
    [SerializeField] private SpriteInteraction agency;
    
    [SerializeField ]private ShopElements[] shopElements;
    
  
    void Start()
    {             
        //agency.popUp += OpenTab;
       
      DayManager.instance.SetText();
      StartAgencyPanel();
     
     }
 

    void StartAgencyPanel(){
     //   shopElements = FindObjectsOfType<ShopElements>();
       for (int i = 0; i < shopElements.Length; i++)
        {
            shopElements[i].ChoosedHero += OnChooseHero;
            Debug.Log($"assinou OnChooseHero: {i}");
        }
    }

    void OpenTab(){
        if(!buildingPanel.activeInHierarchy){
        buildingPanel.SetActive(true);
        }
     
        StartAgencyPanel();
        Debug.Log("tab open");
    }
    void OnChooseHero(HeroData hero){
        

        HeroPersistance.Instance.myHeros.Add(hero);    
    }
}
