using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPersistance : MonoBehaviour
{
   
    private static HeroPersistance instance;
    [SerializeField] public List<HeroData> myHeros = new();
    

    // Propriedade pública para acessar a instância Singleton
    public static HeroPersistance Instance
    {
        get
        {
            if (instance == null)
            {
                // Se a instância ainda não foi criada, tenta encontrá-la na cena
                instance = FindObjectOfType<HeroPersistance >();

                // Se não encontrar, cria uma nova instância
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("MeuSingleton");
                    instance = singletonObject.AddComponent<HeroPersistance>();
                }

                // Garante que a instância persista entre as cenas
                DontDestroyOnLoad(instance.gameObject);
            }

            return instance;
        }
    }

    // Métodos e propriedades do seu Singleton podem ser adicionados aqui

    private void Awake()
    {
        // Garante que há apenas uma instância deste objeto na cena
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
    }

   private void HeroMainData(){
   ///read json
   }

    
}

 


