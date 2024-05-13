using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrimeDataBase : MonoBehaviour
{
    public CrimeData[] crimeData;    

   public static CrimeDataBase instance;
    private void Awake()
    {                  
 
       if (instance != null && instance != this)
        {
            Destroy(this);
        }else{
            DontDestroyOnLoad(this);
            instance = this;
        
        }
    }
    void Start()
    {
        
    }

  public string LocalName(int index){
 return crimeData[index].localName;
  }
public float DangerValue(int index){
return crimeData[index].crimeValue;
}
public void CrimeValueChange(float value , int index){
crimeData[index].crimeValue += value; 
}
}
