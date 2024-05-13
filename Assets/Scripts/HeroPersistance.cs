using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;
using UnityEngine.UIElements;

public class HeroPersistance : MonoBehaviour
{
   
    private static HeroPersistance instance;
    public List<HeroData> myHeros ;
   // [SerializeField] private List<Hero> heroRefs;
    
    //[SerializeField]private List<HeroData> heroDataBase;
    


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
 
    void Start()
    {
 
   HeroMainData();
    }

   private void HeroMainData(){
    string fileName = "HeroJson";
    myHeros = FileHandler.ReadListFromJSON<HeroData>(fileName);

  

   
   }

  


}


 


