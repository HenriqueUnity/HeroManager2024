using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalCrime : MonoBehaviour
{
    [SerializeField] public CrimeData data;
    public delegate void SetCrimeData(CrimeData data);
    public event SetCrimeData SettedCrimeData;
    public void DataSetted(){
       SettedCrimeData?.Invoke(data);
    }
}
