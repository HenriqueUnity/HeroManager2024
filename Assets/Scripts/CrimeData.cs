using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Data",menuName ="CrimeData/newCrime")]

public class CrimeData : ScriptableObject
{
   public CrimeLordData crimeLord;
   public string localName;
   public float crimeValue;
   public float dangerValue;
   public int operationSlot;   

   public List<string> crimeTraits = new();
    
}
