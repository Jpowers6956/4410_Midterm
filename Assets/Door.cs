using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject keySprite;
    public GameObject endScreen;
    public GameObject endText;

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player") && !keySprite.activeSelf){
                endText.SetActive(true);
                endScreen.SetActive(true); 
                
        }

    }

}
