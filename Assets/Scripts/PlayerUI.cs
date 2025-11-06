using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

namespace StarterAssets
{

    public class PlayerUI : MonoBehaviour
    {

        public static PlayerUI instance;
        [SerializeField]
        public FirstPersonController _fpsController;

        public GameObject shop;
        public float money = 100;
        public bool hasShoes = false;
        public bool isInteractingWithPlayer;

        public GameObject shopDialogUI;
        public GameObject mainUI;
        public GameObject gameoverUI;


        public TMP_Text moneyText;
        public float difficlutyScaler;




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

        public void gameOver()
        {
            if (money < 0.0f)
            {
                mainUI.SetActive(false);
                shopDialogUI.SetActive(false);
                gameoverUI.SetActive(true);

            }
        }

        // Start is called before the first frame update
        void Start()
        {
            _fpsController = GetComponent<FirstPersonController>();
            shopDialogUI.SetActive(false);
            mainUI.SetActive(true);
            gameoverUI.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            gameOver();
            money -= Time.deltaTime * difficlutyScaler;
            moneyText.SetText("Money: " + money);
            jumpMod();
            
        }
    }
}
