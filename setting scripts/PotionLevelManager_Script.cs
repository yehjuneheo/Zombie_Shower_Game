using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PotionLevelManager_Script : MonoBehaviour
{
    public Button HealthPotionButton;
    public Button SpeedPotionButton;
    public Button AttackPotionButton;

    public GameObject HealthPotionButton2;
    public GameObject SpeedPotionButton2;
    public GameObject AttackPotionButton2;

    public GameObject HealthPotionGoldText;
    public GameObject SpeedPotionGoldText;
    public GameObject AttackPotionGoldText;

    public GameObject HealthPotionMax;
    public GameObject SpeedPotionMax;
    public GameObject AttackPotionMax;

    private int HealthPotionLevel;
    private int SpeedPotionLevel;
    private int AttackPotionLevel;

    public Color fillColor;
    public Color whiteColor;

    public Image HealthPotion1;
    public Image HealthPotion2;
    public Image HealthPotion3;
    public Image HealthPotion4;
    public Image HealthPotion5;
    public Image HealthPotion6;
    public Image HealthPotion7;
    public Image HealthPotion8;
    public Image HealthPotion9;
    public Image HealthPotion10;

    public Image SpeedPotion1;
    public Image SpeedPotion2;
    public Image SpeedPotion3;
    public Image SpeedPotion4;
    public Image SpeedPotion5;
    public Image SpeedPotion6;
    public Image SpeedPotion7;
    public Image SpeedPotion8;
    public Image SpeedPotion9;
    public Image SpeedPotion10;

    public Image AttackPotion1;
    public Image AttackPotion2;
    public Image AttackPotion3;
    public Image AttackPotion4;
    public Image AttackPotion5;
    public Image AttackPotion6;
    public Image AttackPotion7;
    public Image AttackPotion8;
    public Image AttackPotion9;
    public Image AttackPotion10;

    int healthpotionTemp;
    int speedpotionTemp;
    int attackpotionTemp;

    int goldAmount;
    int tokenAmount;

    public TextMeshProUGUI goldAmountText;
    public TextMeshProUGUI tokenAmountText;

    public TextMeshProUGUI healthpotiongoldText;
    public TextMeshProUGUI speedpotiongoldText;
    public TextMeshProUGUI attackpotiongoldText;


    int healthpotiongold = 400;
    int speedpotiongold = 400;
    int attackpotiongold = 400;

    private void Start()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        tokenAmount = PlayerPrefs.GetInt("TokenAmount");
    }

    private void Update()
    {
        goldAmountText.text = goldAmount.ToString();
        tokenAmountText.text = tokenAmount.ToString();

        if (PlayerPrefs.GetInt("HealthPotionLevel") >= 8)
        {
            healthpotiongold = 2500;

        }
        else if (PlayerPrefs.GetInt("HealthPotionLevel") >= 6)
        {
            healthpotiongold = 2000;

        }
        else if (PlayerPrefs.GetInt("HealthPotionLevel") >= 4)
        {
            healthpotiongold = 1500;

        }
        else if (PlayerPrefs.GetInt("HealthPotionLevel") >= 2)
        {
            healthpotiongold = 1000;

        }
        else
        {
            healthpotiongold = 500;
        }


        if (PlayerPrefs.GetInt("SpeedPotionLevel") >= 8)
        {
            speedpotiongold = 2500;

        }
        else if (PlayerPrefs.GetInt("SpeedPotionLevel") >= 6)
        {
            speedpotiongold = 2000;

        }
        else if (PlayerPrefs.GetInt("SpeedPotionLevel") >= 4)
        {
            speedpotiongold = 1500;

        }
        else if (PlayerPrefs.GetInt("SpeedPotionLevel") >= 2)
        {
            speedpotiongold = 1000;

        }
        else
        {
            speedpotiongold = 500;
        }


        if (PlayerPrefs.GetInt("AttackPotionLevel") >= 8)
        {
            attackpotiongold = 2500;

        }
        else if (PlayerPrefs.GetInt("AttackPotionLevel") >= 6)
        {
            attackpotiongold = 2000;

        }
        else if (PlayerPrefs.GetInt("AttackPotionLevel") >= 4)
        {
            attackpotiongold = 1500;

        }
        else if (PlayerPrefs.GetInt("AttackPotionLevel") >= 2)
        {
            attackpotiongold = 1000;

        }
        else
        {
            attackpotiongold = 500;
        }


        healthpotiongoldText.text = healthpotiongold.ToString();
        speedpotiongoldText.text = speedpotiongold.ToString();
        attackpotiongoldText.text = attackpotiongold.ToString();

        if (PlayerPrefs.GetInt("GoldAmount") >= healthpotiongold)
        {
            HealthPotionButton.interactable = true;

        }
        else
        {
            HealthPotionButton.interactable = false;
        }

        if (PlayerPrefs.GetInt("GoldAmount") >= speedpotiongold)
        {
            SpeedPotionButton.interactable = true;

        }
        else
        {
            SpeedPotionButton.interactable = false;
        }

        if (PlayerPrefs.GetInt("GoldAmount") >= attackpotiongold)
        {
            AttackPotionButton.interactable = true;

        }
        else
        {
            AttackPotionButton.interactable = false;
        }


        if (PlayerPrefs.GetInt("HealthPotionLevel") < 10)
        {
            HealthPotionButton2.SetActive(true);
            HealthPotionGoldText.SetActive(true);
            HealthPotionMax.SetActive(false);
        }
        else
        {
            HealthPotionButton2.SetActive(false);
            HealthPotionGoldText.SetActive(false);
            HealthPotionMax.SetActive(true);
        }

        if (PlayerPrefs.GetInt("SpeedPotionLevel") < 10)
        {
            SpeedPotionButton2.SetActive(true);
            SpeedPotionGoldText.SetActive(true);
            SpeedPotionMax.SetActive(false);

        }
        else
        {
            SpeedPotionButton2.SetActive(false);
            SpeedPotionGoldText.SetActive(false);
            SpeedPotionMax.SetActive(true);
        }

        if (PlayerPrefs.GetInt("AttackPotionLevel") < 10)
        {
            AttackPotionButton2.SetActive(true);
            AttackPotionGoldText.SetActive(true);
            AttackPotionMax.SetActive(false);

        }
        else
        {
            AttackPotionButton2.SetActive(false);
            AttackPotionGoldText.SetActive(false);
            AttackPotionMax.SetActive(true);
        }

        UpdateLevels();
    }

    public void HealthPotionUP()
    {
        healthpotionTemp = PlayerPrefs.GetInt("HealthPotionLevel");
        PlayerPrefs.SetInt("HealthPotionLevel", healthpotionTemp += 1);
        goldAmount -= healthpotiongold;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
    }

    public void SpeedPotionUP()
    {
        speedpotionTemp = PlayerPrefs.GetInt("SpeedPotionLevel");
        PlayerPrefs.SetInt("SpeedPotionLevel", speedpotionTemp += 1);
        goldAmount -= speedpotiongold;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
    }

    public void AttackPotionUP()
    {
        attackpotionTemp = PlayerPrefs.GetInt("AttackPotionLevel");
        PlayerPrefs.SetInt("AttackPotionLevel", attackpotionTemp += 1);
        goldAmount -= attackpotiongold;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
    }

    public void UpdateLevels()
    {
        HealthPotionLevel = PlayerPrefs.GetInt("HealthPotionLevel");

        if (HealthPotionLevel >= 1)
        {
            HealthPotion1.color = fillColor;
        }
        else
        {
            HealthPotion1.color = whiteColor;
        }

        if (HealthPotionLevel >= 2)
        {
            HealthPotion2.color = fillColor;
        }
        else
        {
            HealthPotion2.color = whiteColor;
        }

        if (HealthPotionLevel >= 3)
        {
            HealthPotion3.color = fillColor;
        }
        else
        {
            HealthPotion3.color = whiteColor;
        }

        if (HealthPotionLevel >= 4)
        {
            HealthPotion4.color = fillColor;
        }
        else
        {
            HealthPotion4.color = whiteColor;
        }

        if (HealthPotionLevel >= 5)
        {
            HealthPotion5.color = fillColor;
        }
        else
        {
            HealthPotion5.color = whiteColor;
        }

        if (HealthPotionLevel >= 6)
        {
            HealthPotion6.color = fillColor;
        }
        else
        {
            HealthPotion6.color = whiteColor;
        }

        if (HealthPotionLevel >= 7)
        {
            HealthPotion7.color = fillColor;
        }
        else
        {
            HealthPotion7.color = whiteColor;
        }

        if (HealthPotionLevel >= 8)
        {
            HealthPotion8.color = fillColor;
        }
        else
        {
            HealthPotion8.color = whiteColor;
        }

        if (HealthPotionLevel >= 9)
        {
            HealthPotion9.color = fillColor;
        }
        else
        {
            HealthPotion9.color = whiteColor;
        }

        if (HealthPotionLevel >= 10)
        {
            HealthPotion10.color = fillColor;
        }
        else
        {
            HealthPotion10.color = whiteColor;
        }

        SpeedPotionLevel = PlayerPrefs.GetInt("SpeedPotionLevel");

        if (SpeedPotionLevel >= 1)
        {
            SpeedPotion1.color = fillColor;
        }
        else
        {
            SpeedPotion1.color = whiteColor;
        }

        if (SpeedPotionLevel >= 2)
        {
            SpeedPotion2.color = fillColor;
        }
        else
        {
            SpeedPotion2.color = whiteColor;
        }

        if (SpeedPotionLevel >= 3)
        {
            SpeedPotion3.color = fillColor;
        }
        else
        {
            SpeedPotion3.color = whiteColor;
        }

        if (SpeedPotionLevel >= 4)
        {
            SpeedPotion4.color = fillColor;
        }
        else
        {
            SpeedPotion4.color = whiteColor;
        }

        if (SpeedPotionLevel >= 5)
        {
            SpeedPotion5.color = fillColor;
        }
        else
        {
            SpeedPotion5.color = whiteColor;
        }

        if (SpeedPotionLevel >= 6)
        {
            SpeedPotion6.color = fillColor;
        }
        else
        {
            SpeedPotion6.color = whiteColor;
        }

        if (SpeedPotionLevel >= 7)
        {
            SpeedPotion7.color = fillColor;
        }
        else
        {
            SpeedPotion7.color = whiteColor;
        }

        if (SpeedPotionLevel >= 8)
        {
            SpeedPotion8.color = fillColor;
        }
        else
        {
            SpeedPotion8.color = whiteColor;
        }

        if (SpeedPotionLevel >= 9)
        {
            SpeedPotion9.color = fillColor;
        }
        else
        {
            SpeedPotion9.color = whiteColor;
        }

        if (SpeedPotionLevel >= 10)
        {
            SpeedPotion10.color = fillColor;
        }
        else
        {
            SpeedPotion10.color = whiteColor;
        }



        AttackPotionLevel = PlayerPrefs.GetInt("AttackPotionLevel");

        if (AttackPotionLevel >= 1)
        {
            AttackPotion1.color = fillColor;
        }
        else
        {
            AttackPotion1.color = whiteColor;
        }

        if (AttackPotionLevel >= 2)
        {
            AttackPotion2.color = fillColor;
        }
        else
        {
            AttackPotion2.color = whiteColor;
        }

        if (AttackPotionLevel >= 3)
        {
            AttackPotion3.color = fillColor;
        }
        else
        {
            AttackPotion3.color = whiteColor;
        }

        if (AttackPotionLevel >= 4)
        {
            AttackPotion4.color = fillColor;
        }
        else
        {
            AttackPotion4.color = whiteColor;
        }

        if (AttackPotionLevel >= 5)
        {
            AttackPotion5.color = fillColor;
        }
        else
        {
            AttackPotion5.color = whiteColor;
        }

        if (AttackPotionLevel >= 6)
        {
            AttackPotion6.color = fillColor;
        }
        else
        {
            AttackPotion6.color = whiteColor;
        }

        if (AttackPotionLevel >= 7)
        {
            AttackPotion7.color = fillColor;
        }
        else
        {
            AttackPotion7.color = whiteColor;
        }

        if (AttackPotionLevel >= 8)
        {
            AttackPotion8.color = fillColor;
        }
        else
        {
            AttackPotion8.color = whiteColor;
        }

        if (AttackPotionLevel >= 9)
        {
            AttackPotion9.color = fillColor;
        }
        else
        {
            AttackPotion9.color = whiteColor;
        }

        if (AttackPotionLevel >= 10)
        {
            AttackPotion10.color = fillColor;
        }
        else
        {
            AttackPotion10.color = whiteColor;
        }
    }
}
