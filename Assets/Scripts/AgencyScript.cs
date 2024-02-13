using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AgencyScript : MonoBehaviour
{

   
    private RecruitData recruit;
    private List<HeroData> hero;
    

    void Start()
    {
    recruit = GameObject.Find("HeroRecruitData").GetComponent<RecruitData>();
    
    hero = recruit.heroRecruit;
    }

}
