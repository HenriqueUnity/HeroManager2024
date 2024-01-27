using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Data",menuName ="CrimeData/newCrime")]

public class CrimeData : ScriptableObject
{
    public CrimeLordData crimeLord;
   public float crimeValue;
   public float dangerValue;
   public List<string> crimeTraits = new();
    
}
