using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class ReadRecruit : MonoBehaviour
{
   private RecruitData recruit;
   private HeroData[]  heroList;
   [SerializeField] private TextMeshProUGUI[] nameText;
   [SerializeField] private TextMeshProUGUI[] powerText;

    void Start()
    {
    recruit = GameObject.Find("HeroRecruitData").GetComponent<RecruitData>();
    heroList = recruit.heroRecruit;

    FirstDebug();
    IndexShuffle();
    DebugList();
    }
  

    

   public void ReadHeroInfo(){
    for (int i = 0; i < heroList.Length -4; i++)
    {
        nameText[i].text = heroList[i].heroName;
        powerText[i].text = heroList[i].power.ToString();
    }
   }

   private void IndexShuffle(){
    System.Random random = new System.Random();
        for (int i = heroList.Length - 1; i > 0; i--)
        {
            // Gera um índice aleatório no intervalo [0, i]
            int randomIndex = random.Next(0, i + 1);

            // Troca os elementos nos índices i e randomIndex
            HeroData temp = heroList[randomIndex];
            heroList[i] = heroList[randomIndex];
            
           
   }   
}
private void FirstDebug(){
    for (int i = 0; i < heroList.Length; i++)
  {
    Debug.Log(heroList[i].heroName);
  }
}
private void DebugList(){
  for (int i = 0; i < heroList.Length; i++)
  {
    Debug.Log(heroList[i].heroName);
  }
}
}
