using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Sound : MonoBehaviour
{
   [SerializeField] private AudioClip audioClip;


   
  public void OnMouseDown()
  {

    Debug.Log("enter in mousedown");
   FindObjectOfType<AudioSource>().PlayOneShot(audioClip);
  }
}
