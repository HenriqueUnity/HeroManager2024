using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;


public class JsonWriteReadData : MonoBehaviour
{
   
    private List<HeroData> heroData;
    
  
  
    void Start()
    { 
        heroData = HeroPersistance.Instance.myHeros;  
        //Debug.Log(Application.persistentDataPath);   
             
    }

    public void SaveToJson(){
      try
   {
    List<HeroData> data = heroData;           
   
   
    string filePath = "HeroJson";
     FileHandler.SaveToJSON<HeroData>(data,filePath);     

    Debug.Log("Hero data saved to: " + filePath); }
      catch (Exception e)
    {
    Debug.LogError("Error saving HeroData: " + e.Message); }

    }

    // public void LoadToJson(){
    //     string json = File.ReadAllText(Application.dataPath + "/HeroDataFile.json");
        
    //     string data = JsonUtility.FromJson<string>(json);              
        
         
    // }
}
