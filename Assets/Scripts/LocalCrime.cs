using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LocalCrime : MonoBehaviour
{
    [SerializeField] public CrimeData data;
    public delegate void SetCrimeData(CrimeData data);
    public event SetCrimeData SettedCrimeData;
    private TextMeshProUGUI localNameText;

  
    void Start()
    {
        localNameText = GetComponentInChildren<TextMeshProUGUI>();
        localNameText.text = data.localName;
    }
    public void DataSetted(){
       SettedCrimeData?.Invoke(data);
    }
}
