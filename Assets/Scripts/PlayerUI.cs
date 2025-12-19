using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StarterAssets
{

    public class PlayerUI : MonoBehaviour
    {

        public static PlayerUI instance;
        [SerializeField]
        public FirstPersonController _fpsController;

        public GameObject shop;
        public float money = 150;
        public float startingMoney = 100;
        public bool hasShoes = false;
        public bool isInteractingWithPlayer;

        public GameObject shopDialogUI;
        public GameObject mainUI;
        public GameObject gameoverUI;
        public Button restartBTN;


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
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;




            }
        }

        // Start is called before the first frame update
        void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
            _fpsController = GetComponent<FirstPersonController>();
            shopDialogUI.SetActive(false);
            mainUI.SetActive(true);
            gameoverUI.SetActive(false);
            restartBTN.onClick.AddListener(restartGame);

        }

        // Update is called once per frame
        void Update()
        {
            gameOver();
            scaleMoneyText(moneyText);
            jumpMod();
            
        }

        public void restartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void scaleMoneyText(TMP_Text moneyCount)
        {
            money -= Time.deltaTime * difficlutyScaler;
            moneyCount.SetText("$" + money.ToString("F2"));
            float moneyTrueFontSize = (money / startingMoney) * 100;
            float moneyMinFontSize = 30;
            float moneyMaxFontSize = 50;

                if ( money > 0 && money < 30)
                {
                    moneyCount.fontSize = moneyMinFontSize;
                }
                else if (money > 100)
                {
                    moneyCount.fontSize = moneyMaxFontSize;
                }
                else if(money < 100 && money > 31)
                {
                    moneyCount.fontSize = moneyTrueFontSize;
                }
               


                    
            
          
        }
    }
}
