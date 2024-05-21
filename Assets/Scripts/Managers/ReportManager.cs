using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ReportManager : MonoBehaviour
{
private DayAction dayActionButton;
private DayManager dayManager;

public List<Report> _reports;


[Header("General info")]

[SerializeField] private GameObject ReportOVPanel;
[SerializeField] private TextMeshProUGUI localNameTxt;
[SerializeField] private TextMeshProUGUI enemiesTxt; 

[SerializeField] private TextMeshProUGUI crimeUpdateTxt;
[SerializeField] private TextMeshProUGUI resultTxt; 

[Header("Hero Info")]
[SerializeField] private GameObject[] HeroInfoPanel;
[SerializeField] private TextMeshProUGUI[] heroNametxt;
[SerializeField] private TextMeshProUGUI[] heroLifeModtxt, heroLifeTxt;
[SerializeField] private TextMeshProUGUI[] fameModtxt, fameTxt;
[SerializeField] private TextMeshProUGUI[] fadigueModtxt,fadigueTxt;


void Start()
    {

_reports = ReportPersistance.Instance.reports;
dayActionButton = GameObject.Find("ButtonAction").
GetComponent<DayAction>();
dayManager = DayManager.instance;

 dayActionButton.DayButtonClicked += SetAction;
_reports = ReportPersistance.Instance.reports;
//ReportStart();
    }
private void SetAction(){
SceneManager.sceneLoaded += dayManager.OnSceneLoaded;
}
  
public void ReportStart(int index){
    ReportOVPanel.SetActive(true);
    localNameTxt.text = CrimeDataBase.instance.crimeData[index].localName;
    enemiesTxt.text = $"{_reports[index].enemiesDefeated}/{_reports[index].enemiesNumber.ToString()}";
   
    crimeUpdateTxt.text = $"{CrimeChangeString(index)}  {CrimeCalc(index).ToString()}";
    resultTxt.text = _reports[index].result;
    HeroShow(index);

}

private void HeroShow(int index){

  for (int i = 0; i < HeroInfoPanel.Length; i++)
  {
    HeroInfoPanel[i].SetActive(false);
  }
 for (int i = 0; i < _reports[index].heroesReport.Count; i++)
  {
    HeroInfoPanel[i].SetActive(true);
  }
}

private float CrimeCalc(int index)
{
   float crimeCalc = CrimeDataBase.instance.crimeData[index].crimeValue -_reports[index].crimeChange;
   
  return crimeCalc;
}

private string CrimeChangeString(int index){
    if(_reports[index].crimeChange > 0 ){
        return $"-({_reports[index].crimeChange}) /";
    }else{

    return $"({_reports[index].crimeChange}) /";
    }
}


}
