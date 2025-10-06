using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace StarterAssets
{


    public class ShopScript : MonoBehaviour
    {
        Button[] buttons;
        int shoesCost;

        public static ShopScript instance;
        public PlayerUI playerUI;
        public FirstPersonController fpsController;


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

            buyBTN.onClick.AddListener(shoesBuy);
            shopDialogUI.SetActive(false);

        }

        private void shoesBuy()
        {
            if ((playerUI.money > 50) && (playerUI.hasShoes == false))
            {
                playerUI.money = playerUI.money - 50;
                playerUI.hasShoes = true;
                Debug.Log("shoes is true");

            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerUI.inShop();
            }

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerUI.exitShop();
            }

        }
    }
}
