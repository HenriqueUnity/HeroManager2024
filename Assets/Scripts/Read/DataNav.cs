using System;
using UnityEngine;

public class DataNav : MonoBehaviour
{
   private HeroPersistance _instance;
   private int index;

   public Action<int> OnNext;
   
    void Start()
    {
        _instance = HeroPersistance.Instance;
         index = 1;
    }

    // Update is called once per frame
    public void NextIndex(){

    
        if(_instance.myHeros.Count>1){
         OnNext?.Invoke(index);

         if(index == _instance.myHeros.Count -1){
            index = 0;
            return;
         }
         index++;
        }
    }
}
