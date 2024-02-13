using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleList : MonoBehaviour
{
  private RecruitData recruit;
   private List<HeroData>  heroList = new();
   void Start()
   {
       recruit = GetComponent<RecruitData>();
        heroList = recruit.heroRecruit;
       ShuffleList0(heroList);
   }
    public void ShuffleList0<HeroData>(List<HeroData> m_list){
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
}