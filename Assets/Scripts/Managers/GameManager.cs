using UnityEngine;

public class GameManager : MonoBehaviour
{  
    [SerializeField] private GameObject buildingPanel;
    [SerializeField] private SpriteInteraction agency;
    private ShopElements[] shopElements;
   // private HeroPersistance heroPersistance;
    void Start()
    {             
        agency.popUp += OpenTab;
        shopElements = FindObjectsOfType<ShopElements>();
      //  heroPersistance = FindObjectOfType<HeroPersistance>();
       for (int i = 0; i < shopElements.Length; i++)
        {
            shopElements[i].ChoosedHero += OnChooseHero;
        }
     }
 

    

    void OpenTab(){
        if(!buildingPanel.activeInHierarchy){
        buildingPanel.SetActive(true);
        }
        else
        Debug.Log("tab open");
    }
    void OnChooseHero(HeroData hero){
    HeroPersistance.Instance.myHeros.Add(hero);    
    }
}
