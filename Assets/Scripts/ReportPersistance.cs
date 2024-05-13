using System.Collections.Generic;
using UnityEngine;

public class ReportPersistance : MonoBehaviour
{
    // Start is called before the first frame update
   private static ReportPersistance instance;
   public List<Report> reports;
   



    public static ReportPersistance Instance
    {
        get
        {
            if (instance == null)
            {
            
                instance = FindObjectOfType<ReportPersistance>();

              
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("HeroPersistance");
                    instance = singletonObject.AddComponent<ReportPersistance>();
                }

     
        
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

    public void SetReport(Report reportData){
     reports.Add(reportData);
    }
    public void ClearReports(){
    reports.Clear();
    }
}
