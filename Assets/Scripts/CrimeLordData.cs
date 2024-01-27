using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Data",menuName ="CrimeLordData/NewCrimeLord")]
public class CrimeLordData : ScriptableObject
{
    public string lordName;
    public float lordPower;
    
    public List <string> traits = new ();

  
}
