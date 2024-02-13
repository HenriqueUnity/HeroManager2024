using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerResource : MonoBehaviour
{
   private static PlayerResource instance;
   public int money;
   [SerializeField] private TextMeshProUGUI moneyText;
    public static PlayerResource Instance
    {
        get
        {
            if (instance == null)
            {
            
                // Se a instância ainda não foi criada, tenta encontrá-la na cena
                instance = FindObjectOfType<PlayerResource>();

                // Se não encontrar, cria uma nova instância
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("PlayerResource");
                    instance = singletonObject.AddComponent<PlayerResource>();
                }

                // Garante que a instância persista entre as cenas
              
                Debug.Log("Instance created");
            }

            return instance;
        }
    }

    

    private void Awake()
    {
       
     
       
          DontDestroyOnLoad(this);
        
       if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
   moneyText = GameObject.Find("moneyText").GetComponent<TextMeshProUGUI>();
    UpdateAmount();

    }
    public void UpdateAmount(){
         moneyText.text = money.ToString();
    }
}
