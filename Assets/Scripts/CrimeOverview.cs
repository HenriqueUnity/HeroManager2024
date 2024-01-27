using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class CrimeOverview : MonoBehaviour
{ 

    [SerializeField] private CrimeData m_crimeData;
    [SerializeField] private TextMeshProUGUI crimeAmount_Text;
    [SerializeField] private TextMeshProUGUI dangerAmount_Text;
    [SerializeField] private TextMeshProUGUI[] traits_Text;
    
    //lord info 
    [Header("Lord Atributes")]
    [SerializeField] private TextMeshProUGUI lordName;
    [SerializeField] private TextMeshProUGUI lordPower;
    [SerializeField] private TextMeshProUGUI[] lordTraits; 
        

    void Start()
    {
        ReadData();
    }

    // Update is called once per frame
    void ReadData(){
        crimeAmount_Text.text = m_crimeData.crimeValue.ToString();
        dangerAmount_Text.text = m_crimeData.dangerValue.ToString();
        
        for (int i = 0; i <  m_crimeData.crimeTraits.Count; i++)
        {         
         traits_Text[i].text = m_crimeData.crimeTraits[i];            
        }

        ////////////// crimelord
        ///

        lordName.text = m_crimeData.crimeLord.lordName;
        lordPower.text = m_crimeData.crimeLord.lordPower.ToString();
        
        for (int i = 0; i < m_crimeData.crimeLord.traits.Count; i++)
        {
            lordTraits[i].text = m_crimeData.crimeLord.traits[i];
        }


    }
}
