using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SpriteInteraction[] buildings;
    [SerializeField] private GameObject buildingPanel;
    void Start()
    {
        for (int i = 0; i < buildings.Length; i++)
        {
            buildings[i].popUp += OpenTab;
        }
    }

   

  

    void OpenTab(){
        if(!buildingPanel.activeInHierarchy){
        buildingPanel.SetActive(true);
        }
        else
        Debug.Log("tab open");
    }
}
