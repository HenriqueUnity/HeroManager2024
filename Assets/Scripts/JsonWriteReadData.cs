using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;

using UnityEngine;

public class JsonWriteReadData : MonoBehaviour
{
   [SerializeField] private TMP_InputField nameField;
   [SerializeField] private TMP_InputField powerField;
   [SerializeField] private TMP_InputField fameField;
   [SerializeField] private TMP_InputField costField;
    public void SaveToJson(){
        HeroData data = new HeroData();

        data.name  = nameField.text;
        data.power = float.Parse(powerField.text);
        data.fame  = float.Parse(fameField.text);
        data.value = float.Parse(costField.text);


        string json = JsonUtility.ToJson(data,true);
        File.WriteAllText(Application.dataPath + "/HeroDataFile.json",json);
    }

    public void LoadToJson(){
        string json = File.ReadAllText(Application.dataPath + "/HeroDataFile.json");
        HeroData data = JsonUtility.FromJson<HeroData>(json);

        nameField.text = data.heroName;
        powerField.text = data.power.ToString();
        fameField.text = data.fame.ToString();
        costField.text = data.value.ToString();
    }
}
