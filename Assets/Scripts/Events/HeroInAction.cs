using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInAction : MonoBehaviour
{
    private static HeroInAction instance;

     
    public Dictionary< int,HeroData> myHerosInAction ;
    
    [SerializeField] private LocalCrime[] localsArray;
     private Dictionary<int,LocalCrime> locals = new();
    
    [SerializeField] private SetSlot[] localSlots;


    
    // Propriedade pública para acessar a instância Singleton
    public static HeroInAction Instance
    {
        get
        {
            if (instance == null)
            {
            
                // Se a instância ainda não foi criada, tenta encontrá-la na cena
                instance = FindObjectOfType<HeroInAction>();

                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("HeroInActionPersistance");
                    instance = singletonObject.AddComponent<HeroInAction>();
                }
                // Garante que a instância persista entre as cenas
                Debug.Log("Instance HeronInAction created");
            }

            return instance;
        }
    }

    

    private void Awake()
    {                  
 
       if (instance != null && instance != this)
        {
            Destroy(this);
        }else{
            DontDestroyOnLoad(this);
            instance = this;
            Debug.Log("instance dont destroyed");
        }
    }
   void Start()
   {
      for (int i = 0; i < localsArray.Length; i++)
      {
        locals.Add(i,localsArray[i]);
        Debug.Log($"{locals[i]}");
        
      } 

      for (int i = 0; i < localSlots.Length; i++)
      {
        localSlots[i].HeroSetted += OnSetHeroes;
      }

   }


   //index == a index do local 
   private void OnSetHeroes(int index, HeroData hero){
    myHerosInAction.Add(index,hero);


   }
 
}
