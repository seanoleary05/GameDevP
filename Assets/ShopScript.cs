using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{

    public static ShopScript instance;
  
    public bool isInteractingWithPlayer;
    public BoxCollider buttonRange;


    public GameObject shopDialogUI;
    public Button buyBTN;
    public Button exitBTN;

    public GameObject buyPanelUI;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        shopDialogUI.SetActive(false);
        
    }

    private void Update()
    {
        Debug.Log(isInteractingWithPlayer);
    }



    private void OnTriggerEnter(Collider other)
    { 
       if (other.CompareTag("Player"))
       {
            isInteractingWithPlayer = true;
            shopDialogUI.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
       }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractingWithPlayer = false;
            shopDialogUI.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
        }

    }
}
