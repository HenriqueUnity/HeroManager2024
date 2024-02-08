using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class ReadRecruit : MonoBehaviour
{
   private RecruitData recruit;
   private List<HeroData>  heroList = new();
   [SerializeField] private TextMeshProUGUI[] nameText;
   [SerializeField] private TextMeshProUGUI[] powerText;

    void Start()
    {
    recruit = GameObject.Find("HeroRecruitData").GetComponent<RecruitData>();
    heroList = recruit.heroRecruit;

   
    ShuffleList(heroList);
   
    }
  

    

   public void ReadHeroInfo(){
    for (int i = 0; i < heroList.Count -4; i++)
    {
        nameText[i].text = heroList[i].heroName;
        powerText[i].text = heroList[i].power.ToString();
    }
   }



   public void ShuffleList<HeroData>(List<HeroData> m_list){
    System.Random r = new System.Random();

    for (int i = m_list.Count - 1; i > 0; i--)
        {
            // Gera um índice aleatório no intervalo [0, i]
            int randomIndex = r.Next(0, i + 1);


            HeroData temp = m_list[i];
            m_list[i] = m_list[randomIndex];
            m_list[randomIndex] = temp;

   }

  
}
// private void FirstDebug(){
//     for (int i = 0; i < heroList.Count; i++)
//   {
//     Debug.Log(heroList[i].heroName);
//   }
// }
// private void DebugList(){
//   for (int i = 0; i < heroList.Count; i++)
//   {
//     Debug.Log(heroList[i].heroName);
//   }
// }
}
