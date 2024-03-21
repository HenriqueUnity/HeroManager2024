using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class ShopElements : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI powertxt;
   [SerializeField] private HeroData heroAvailable;
   private Image portraitSPrite;
  private Button actionButton;
  

  public delegate void ChooseHero(HeroData hero);
  public event ChooseHero ChoosedHero;
   
    void Start()
    {
      portraitSPrite = GetComponent<Image>();
      portraitSPrite.sprite = heroAvailable.spritePortrait;
      actionButton = GetComponentInChildren<Button>();
      actionButton.onClick.AddListener(ChooseFunction);
      nameText.text = heroAvailable.heroName;
      powertxt.text = heroAvailable.power.ToString();

    }

    // Update is called once per frame
    void ChooseFunction(){
      Debug.Log("função atribuida");
      ChoosedHero?.Invoke(heroAvailable);
      actionButton.interactable = false;

    }
}
