using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StarterAssets
{

    public class PlayerUI : MonoBehaviour
    {

        public static PlayerUI instance;
        [SerializeField]
        public FirstPersonController _fpsController;
        public GameObject shop;
        public int money = 100;
        public bool hasShoes = false;
        public bool isInteractingWithPlayer;
        public GameObject shopDialogUI;



        public void jumpMod()
        {
            if (hasShoes == true)
            {
                _fpsController.JumpHeight = 10.0f;

            }
        }




        public void Awake()
        {
            instance = this;
        }


        public void inShop()
        {
            isInteractingWithPlayer = true;
            shopDialogUI.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }

        public void exitShop()
        {
            isInteractingWithPlayer = false;
            shopDialogUI.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;

        }

        // Start is called before the first frame update
        void Start()
        {
            _fpsController = GetComponent<FirstPersonController>();
            shopDialogUI.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            jumpMod();
            Debug.Log(_fpsController.JumpHeight);
        }
    }
}
