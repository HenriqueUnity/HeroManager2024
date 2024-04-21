using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class HeroInAction : MonoBehaviour
{
    private static HeroInAction instance;

   
    public List<HeroData> heroInAction0 = new();
    public List<HeroData> heroInAction1 = new();
    public List<HeroData> heroInAction2 = new();
    public List<HeroData> heroInAction3 = new();

   // [SerializeField] private LocalCrime[] localsArray;
   //  private Dictionary<int,LocalCrime> locals = new();
    
    public SetSlot[] localSetSlot;   

    
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
   void Start(){
   

    //   for (int i = 0; i < localsArray.Length; i++)
    //   {
    //     locals.Add(i,localsArray[i]);
    //     Debug.Log($"{locals[i]}");
        
    //   } 
     
   SetButtons();
    

   }
   public void SetButtons(){
    for (int i = 0; i < localSetSlot.Length; i++)
      {
        localSetSlot[i].HeroSetted += OnSetHeroes;
      }
   }


   //index == a index do local 
   private void OnSetHeroes(int index, HeroData hero){
    
    switch (index)
    {
        case 0:
        heroInAction0.Add(hero);
        Debug.Log($"{hero.heroName} adicionado");
        break; 
        case 1:
        heroInAction1.Add(hero);
        Debug.Log($"{hero.heroName} adicionado");
        break;
        case 2:
        heroInAction2.Add(hero);
        Debug.Log($"{hero.heroName} adicionado");

        break; 
        case 3:
        heroInAction3.Add(hero);
        Debug.Log($"{hero.heroName} adicionado");

        break;
    }
    

   }

   public void SetAllSlots(){
  try
   {
      for (int i = 0; i < 3; i++)
   {
    GameObject[] slotGameObject = GameObject.FindGameObjectsWithTag("SetSlot");
    localSetSlot[i] = slotGameObject[i].GetComponent<SetSlot>();
   }
   }
   catch (System.Exception)
   {    
    Debug.Log("fora de crime Scene");
   } 
   }
 

}




// [Serializable] 

// public class NewDict
// {
// [SerializeField] NewDictItem[] thisDictItems;
 
//  public Dictionary<int,LocalCrime> ToDictionary(){

//  Dictionary<int,LocalCrime> newDict = new();



//  foreach (var item in thisDictItems)
//  {
//     newDict.Add(item.index,item.local);
//  }
//  return newDict;
//  }
// }


// [Serializable]
// public class NewDictItem
// {
//     public int index;
//     public LocalCrime local;
//}

// public class SerializableDictionary<int,ocalCrime> : Dictionary<int, LocalCrime>, ISerializationCallbackReceiver
// {
//     [SerializeField]
//     private List<int> _index = new ();

//     [SerializeField]
//     private List<LocalCrime>_locals = new ();

//     public void OnBeforeSerialize()
//     {
//         _index.Clear();
//        _locals.Clear();

//         foreach (var item in this)
//         {
//             _index.Add(item.Key);
//            _locals.Add(item.Value);
//         }
//     }

//     public void OnAfterDeserialize()
//     {
//         Clear();

//         for (int i = 0; i < _index.Count; i++)
//         {
//             this[_index[i]] =_locals[i];
//         }
//     }
// }
