using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

public class HeroPersistance : MonoBehaviour
{
   
    private static HeroPersistance instance;
    public List<HeroData> myHeros ;
    

    // Propriedade pública para acessar a instância Singleton
    public static HeroPersistance Instance
    {
        get
        {
            if (instance == null)
            {
            
                // Se a instância ainda não foi criada, tenta encontrá-la na cena
                instance = FindObjectOfType<HeroPersistance>();

                // Se não encontrar, cria uma nova instância
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("HeroPersistance");
                    instance = singletonObject.AddComponent<HeroPersistance>();
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
    private /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
          HeroMainData();
    }

   private void HeroMainData(){
    string fileName = "HeroJson";
    myHeros = FileHandler.ReadListFromJSON<HeroData>(fileName);

   }

    
}

 


