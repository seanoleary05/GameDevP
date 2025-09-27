using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
  
    public bool isInteractingWithPlayer;
    public BoxCollider buttonRange;


    public GameObject shopDialogUI;
    public Button buyBTN;
    public Button exitBTN;

    public GameObject buyPanelUI;

    private void Start()
    {
        shopDialogUI.SetActive(false);
        
    }
       
   

    private void OnTriggerEnter(Collider other)
    { 
       if (other.CompareTag("Player"))
       {
            isInteractingWithPlayer = true;
            shopDialogUI.SetActive(true);
       }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractingWithPlayer = false;
            shopDialogUI.SetActive(false);
        }

    }
}
