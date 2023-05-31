using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    private int selectedCharacterIndex;
    private Color desiredColor;
    public static string charName;

    private int AttackLevel;
    private int HealthLevel;
    private int SpeedLevel;

    private int BuyPrice;

    public Button GoButton;
    public GameObject BuyButton;
    public Button Buy;

    public Button AttackButton;
    public Button HealthButton;
    public Button SpeedButton;

    public GameObject AttackButton2;
    public GameObject HealthButton2;
    public GameObject SpeedButton2;

    public GameObject AttackMax;
    public GameObject HealthMax;
    public GameObject SpeedMax;

    public GameObject LockPanel;

    public GameObject LevelPanel;

    public Color fillColor;
    public Color whiteColor;

    public Image Attack1;
    public Image Attack2;
    public Image Attack3;
    public Image Attack4;
    public Image Attack5;
    public Image Attack6;
    public Image Attack7;
    public Image Attack8;
    public Image Attack9;
    public Image Attack10;
    public Image Health1;
    public Image Health2;
    public Image Health3;
    public Image Health4;
    public Image Health5;
    public Image Health6;
    public Image Health7;
    public Image Health8;
    public Image Health9;
    public Image Health10;
    public Image Speed1;
    public Image Speed2;
    public Image Speed3;
    public Image Speed4;
    public Image Speed5;
    public Image Speed6;
    public Image Speed7;
    public Image Speed8;
    public Image Speed9;
    public Image Speed10;

    private int pistoltoken = 1;
    private int snipertoken = 2;
    private int cowboytoken = 3;
    private int soldiertoken = 3;
    private int miniguntoken = 4;
    private int gangstertoken = 3;
    private int fishertoken = 2;
    private int lasertoken = 3;
    private int cheftoken = 1;
    private int minetoken = 1;
    private int ninjatoken = 2;
    private int axetoken = 2;
    private int robbertoken = 1;
    private int spartatoken = 2;
    private int bonetoken = 4;
    private int laserswordtoken = 2;
    private int laserguntoken = 4;
    private int firewizardtoken = 3;
    private int poisonwizardtoken = 3;
    private int electricwizardtoken = 3;
    private int samuraitoken = 2;
    private int grenadetoken = 3;
    private int bazookatoken = 4;
    private int girlstudenttoken = 2;
    private int constructortoken = 3;
    private int viking2token = 1;
    private int nursetoken = 1;
    private int teachertoken = 1;
    private int baseballballtoken = 1;
    private int girlninjatoken = 3;
    private int basketballtoken = 1;
    private int piratetoken = 2;
    private int piratecaptaintoken = 3;
    private int artisttoken = 1;
    private int rockertoken = 3;
    private int vampiretoken = 4;
    private int skitoken = 1;
    private int demontoken = 2;
    private int englandsoldiertoken = 3;
    private int gangsterbosstoken = 4;
    private int indiantoken = 2;
    private int policetoken = 1;

    private int attacktoken;
    private int healthtoken;
    private int speedtoken;

    public TextMeshProUGUI AttackTokenText;
    public TextMeshProUGUI HealthTokenText;
    public TextMeshProUGUI SpeedTokenText;

    public TextMeshProUGUI AttackText;
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI SpeedText;

    int attackTemp;
    int healthTemp;
    int speedTemp;

    int goldAmount;

    int tokenAmount;

    public TextMeshProUGUI goldAmountText;

    public TextMeshProUGUI tokenAmountText;

    public static string difficultyLevel;


    [Header("List of characters")]
    [SerializeField] private List<CharacterSelectObject> characterList = new List<CharacterSelectObject>();

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI characterName;
    [SerializeField] private TextMeshProUGUI characterPrice;
    [SerializeField] private Image characterSplash;
    [SerializeField] private Image backgroundColor;

    [Header("Tweaks")]
    [SerializeField] private float backgroundColorTransitionSpeed = 10.0f;

    private void Start()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        tokenAmount = PlayerPrefs.GetInt("TokenAmount");

        UpdateLevels();
        UpdateCharacterSelectionUI();
    }

    private void Update()
    {

        Debug.Log(PlayerPrefs.GetInt("Pistolattacklevel"));
        goldAmountText.text = goldAmount.ToString();
        tokenAmountText.text = tokenAmount.ToString();
        backgroundColor.color = Color.Lerp(backgroundColor.color, desiredColor, Time.deltaTime * backgroundColorTransitionSpeed);


        AttackTokenText.text = attacktoken.ToString();
        HealthTokenText.text = healthtoken.ToString();
        SpeedTokenText.text = speedtoken.ToString();


        UpdateCharacterSelectionUI();
        UpdateLevels();

        if (AttackLevel >= 8)
        {
            attacktoken += 8;
        }
        else if (AttackLevel >= 6)
        {
            attacktoken += 6;
        }
        else if (AttackLevel >= 4)
        {
            attacktoken += 4;
        }
        else if (AttackLevel >= 2)
        {
            attacktoken += 2;
        }
        else
        {
            attacktoken += 0;
        }


        if (HealthLevel >= 8)
        {
            healthtoken += 8;
        }
        else if (HealthLevel >= 6)
        {
            healthtoken += 6;
        }
        else if (HealthLevel >= 4)
        {
            healthtoken += 4;
        }
        else if (HealthLevel >= 2)
        {
            healthtoken += 2;
        }
        else
        {
            healthtoken += 0;
        }


        if (SpeedLevel >= 8)
        {
            speedtoken += 8;
        }
        else if (SpeedLevel >= 6)
        {
            speedtoken += 6;
        }
        else if (SpeedLevel >= 4)
        {
            speedtoken += 4;
        }
        else if (SpeedLevel >= 2)
        {
            speedtoken += 2;
        }
        else
        {
            speedtoken += 0;
        }


        if (goldAmount >= BuyPrice)
        {
            Buy.interactable = true;
        }
        else
        {
            Buy.interactable = false;
        }
    }

    public void LeftArrow()
    {
        SoundManagerScript.PlaySound("buttonclick");
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0)
        {
            selectedCharacterIndex = characterList.Count - 1;
        }
        UpdateCharacterSelectionUI();
        UpdateLevels();
    }

    public void RightArrow()
    {
        SoundManagerScript.PlaySound("buttonclick");
        selectedCharacterIndex++;
        if (selectedCharacterIndex == characterList.Count)
        {
            selectedCharacterIndex = 0;
        }
        UpdateCharacterSelectionUI();
        UpdateLevels();
    }

    public void EasyConfirm()
    {
        difficultyLevel = "easy";
        SoundManagerScript.PlaySound("buttonclick");
        charName = characterList[selectedCharacterIndex].characterName;
        ScoreScript.scoreValue = 0;
        GameManagerScript.gameEnded = false;
        Time.timeScale = 1f;
    }

    public void MediumConfirm()
    {
        difficultyLevel = "medium";
        SoundManagerScript.PlaySound("buttonclick");
        charName = characterList[selectedCharacterIndex].characterName;
        ScoreScript.scoreValue = 0;
        GameManagerScript.gameEnded = false;
        Time.timeScale = 1f;
    }

    public void HardConfirm()
    {
        difficultyLevel = "hard";
        SoundManagerScript.PlaySound("buttonclick");
        charName = characterList[selectedCharacterIndex].characterName;
        ScoreScript.scoreValue = 0;
        GameManagerScript.gameEnded = false;
        Time.timeScale = 1f;
    }

    public void LevelSelectOpen()
    {
        LevelPanel.SetActive(true);
    }

    public void LevelSelectClose()
    {
        LevelPanel.SetActive(false);
    }

    public void AttackUp()
    {
        if (selectedCharacterIndex == 0)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Pistolattacklevel");
                PlayerPrefs.SetInt("Pistolattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);

            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 14)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Sniperattacklevel");
                PlayerPrefs.SetInt("Sniperattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 24)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Shotgunattacklevel");
                PlayerPrefs.SetInt("Shotgunattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 28)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Rifleattacklevel");
                PlayerPrefs.SetInt("Rifleattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 39)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Minigunattacklevel");
                PlayerPrefs.SetInt("Minigunattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 30)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Tommyattacklevel");
                PlayerPrefs.SetInt("Tommyattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 12)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Fisherattacklevel");
                PlayerPrefs.SetInt("Fisherattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 35)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Laserattacklevel");
                PlayerPrefs.SetInt("Laserattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 10)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Chefattacklevel");
                PlayerPrefs.SetInt("Chefattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 1)
        {

            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Mineattacklevel");
                PlayerPrefs.SetInt("Mineattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 22)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Ninjaattacklevel");
                PlayerPrefs.SetInt("Ninjaattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 21)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Axeattacklevel");
                PlayerPrefs.SetInt("Axeattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 2)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Robberattacklevel");
                PlayerPrefs.SetInt("Robberattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 20)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Spartaattacklevel");
                PlayerPrefs.SetInt("Spartaattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 36)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Boneattacklevel");
                PlayerPrefs.SetInt("Boneattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 19)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Laserswordattacklevel");
                PlayerPrefs.SetInt("Laserswordattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 38)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Lasergunattacklevel");
                PlayerPrefs.SetInt("Lasergunattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 27)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Firewizardattacklevel");
                PlayerPrefs.SetInt("Firewizardattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 25)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Poisonwizardattacklevel");
                PlayerPrefs.SetInt("Poisonwizardattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 26)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Electricwizardattacklevel");
                PlayerPrefs.SetInt("Electricwizardattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 18)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Samuraiattacklevel");
                PlayerPrefs.SetInt("Samuraiattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 29)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Grenadeattacklevel");
                PlayerPrefs.SetInt("Grenadeattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 37)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Bazookaattacklevel");
                PlayerPrefs.SetInt("Bazookaattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 13)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Girlstudentattacklevel");
                PlayerPrefs.SetInt("Girlstudentattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 23)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Constructorattacklevel");
                PlayerPrefs.SetInt("Constructorattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 6)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Viking2attacklevel");
                PlayerPrefs.SetInt("Viking2attacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 11)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Nurseattacklevel");
                PlayerPrefs.SetInt("Nurseattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 3)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Teacherattacklevel");
                PlayerPrefs.SetInt("Teacherattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 4)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("BaseballBallattacklevel");
                PlayerPrefs.SetInt("BaseballBallattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 32)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Girlninjaattacklevel");
                PlayerPrefs.SetInt("Girlninjaattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 5)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Basketballattacklevel");
                PlayerPrefs.SetInt("Basketballattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 17)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Pirateattacklevel");
                PlayerPrefs.SetInt("Pirateattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 33)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Piratecaptainattacklevel");
                PlayerPrefs.SetInt("Piratecaptainattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 7)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Artistattacklevel");
                PlayerPrefs.SetInt("Artistattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 34)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Rockerattacklevel");
                PlayerPrefs.SetInt("Rockerattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 41)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Vampireattacklevel");
                PlayerPrefs.SetInt("Vampireattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 15)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Demonattacklevel");
                PlayerPrefs.SetInt("Demonattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 31)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Englandsoldierattacklevel");
                PlayerPrefs.SetInt("Englandsoldierattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }


        if (selectedCharacterIndex == 40)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Gangsterbossattacklevel");
                PlayerPrefs.SetInt("Gangsterbossattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 16)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Indianattacklevel");
                PlayerPrefs.SetInt("Indianattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 8)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Policeattacklevel");
                PlayerPrefs.SetInt("Policeattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 9)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= attacktoken)
            {
                AttackButton.interactable = true;
                attackTemp = PlayerPrefs.GetInt("Skiattacklevel");
                PlayerPrefs.SetInt("Skiattacklevel", attackTemp += 1);
                tokenAmount -= attacktoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                AttackButton.interactable = false;
            }
        }
    }
    

    public void HealthUp()
    {
        if (selectedCharacterIndex == 0)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Pistolhealthlevel");
                PlayerPrefs.SetInt("Pistolhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 14)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Sniperhealthlevel");
                PlayerPrefs.SetInt("Sniperhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 24)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Shotgunhealthlevel");
                PlayerPrefs.SetInt("Shotgunhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 28)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Riflehealthlevel");
                PlayerPrefs.SetInt("Riflehealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 39)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Minigunhealthlevel");
                PlayerPrefs.SetInt("Minigunhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 30)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Tommyhealthlevel");
                PlayerPrefs.SetInt("Tommyhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 12)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Fisherhealthlevel");
                PlayerPrefs.SetInt("Fisherhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 35)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Laserhealthlevel");
                PlayerPrefs.SetInt("Laserhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 10)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Chefhealthlevel");
                PlayerPrefs.SetInt("Chefhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 1)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Minehealthlevel");
                PlayerPrefs.SetInt("Minehealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 22)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Ninjahealthlevel");
                PlayerPrefs.SetInt("Ninjahealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 21)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Axehealthlevel");
                PlayerPrefs.SetInt("Axehealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 2)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Robberhealthlevel");
                PlayerPrefs.SetInt("Robberhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 20)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Spartahealthlevel");
                PlayerPrefs.SetInt("Spartahealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 36)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Bonehealthlevel");
                PlayerPrefs.SetInt("Bonehealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 19)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Laserswordhealthlevel");
                PlayerPrefs.SetInt("Laserswordhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 38)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Lasergunhealthlevel");
                PlayerPrefs.SetInt("Lasergunhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 27)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Firewizardhealthlevel");
                PlayerPrefs.SetInt("Firewizardhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 25)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Poisonwizardhealthlevel");
                PlayerPrefs.SetInt("Poisonwizardhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 26)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Electricwizardhealthlevel");
                PlayerPrefs.SetInt("Electricwizardhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 18)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Samuraihealthlevel");
                PlayerPrefs.SetInt("Samuraihealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 29)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Grenadehealthlevel");
                PlayerPrefs.SetInt("Grenadehealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 37)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Bazookahealthlevel");
                PlayerPrefs.SetInt("Bazookahealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 13)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Girlstudenthealthlevel");
                PlayerPrefs.SetInt("Girlstudenthealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 23)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Constructorhealthlevel");
                PlayerPrefs.SetInt("Constructorhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 6)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Viking2healthlevel");
                PlayerPrefs.SetInt("Viking2healthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 11)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Nursehealthlevel");
                PlayerPrefs.SetInt("Nursehealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 3)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Teacherhealthlevel");
                PlayerPrefs.SetInt("Teacherhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 4)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("BaseballBallhealthlevel");
                PlayerPrefs.SetInt("BaseballBallhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 32)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Girlninjahealthlevel");
                PlayerPrefs.SetInt("Girlninjahealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 5)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Basketballhealthlevel");
                PlayerPrefs.SetInt("Basketballhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 17)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Piratehealthlevel");
                PlayerPrefs.SetInt("Piratehealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 33)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Piratecaptainhealthlevel");
                PlayerPrefs.SetInt("Piratecaptainhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 7)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Artisthealthlevel");
                PlayerPrefs.SetInt("Artisthealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 34)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Rockerhealthlevel");
                PlayerPrefs.SetInt("Rockerhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 41)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Vampirehealthlevel");
                PlayerPrefs.SetInt("Vampirehealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 15)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Demonhealthlevel");
                PlayerPrefs.SetInt("Demonhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 31)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Englandsoldierhealthlevel");
                PlayerPrefs.SetInt("Englandsoldierhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 40)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Gangsterbosshealthlevel");
                PlayerPrefs.SetInt("Gangsterbosshealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 16)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Indianhealthlevel");
                PlayerPrefs.SetInt("Indianhealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 8)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Policehealthlevel");
                PlayerPrefs.SetInt("Policehealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 9)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= healthtoken)
            {
                HealthButton.interactable = true;
                healthTemp = PlayerPrefs.GetInt("Skihealthlevel");
                PlayerPrefs.SetInt("Skihealthlevel", healthTemp += 1);
                tokenAmount -= healthtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                HealthButton.interactable = false;
            }
        }
    }

    public void SpeedUp()
    {
        if (selectedCharacterIndex == 0)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Pistolspeedlevel");
                PlayerPrefs.SetInt("Pistolspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 14)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Sniperspeedlevel");
                PlayerPrefs.SetInt("Sniperspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 24)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Shotgunspeedlevel");
                PlayerPrefs.SetInt("Shotgunspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 28)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Riflespeedlevel");
                PlayerPrefs.SetInt("Riflespeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 39)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Minigunspeedlevel");
                PlayerPrefs.SetInt("Minigunspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 30)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Tommyspeedlevel");
                PlayerPrefs.SetInt("Tommyspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 12)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Fisherspeedlevel");
                PlayerPrefs.SetInt("Fisherspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 35)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Laserspeedlevel");
                PlayerPrefs.SetInt("Laserspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 10)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Chefspeedlevel");
                PlayerPrefs.SetInt("Chefspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 1)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Minespeedlevel");
                PlayerPrefs.SetInt("Minespeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 22)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Ninjaspeedlevel");
                PlayerPrefs.SetInt("Ninjaspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 21)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Axespeedlevel");
                PlayerPrefs.SetInt("Axespeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 2)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Robberspeedlevel");
                PlayerPrefs.SetInt("Robberspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 20)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Spartaspeedlevel");
                PlayerPrefs.SetInt("Spartaspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 36)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Bonespeedlevel");
                PlayerPrefs.SetInt("Bonespeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 19)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Laserswordspeedlevel");
                PlayerPrefs.SetInt("Laserswordspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 38)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Lasergunspeedlevel");
                PlayerPrefs.SetInt("Lasergunspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 27)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Firewizardspeedlevel");
                PlayerPrefs.SetInt("Firewizardspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 25)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Poisonwizardspeedlevel");
                PlayerPrefs.SetInt("Poisonwizardspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 26)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Electricwizardspeedlevel");
                PlayerPrefs.SetInt("Electricwizardspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 18)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Samuraispeedlevel");
                PlayerPrefs.SetInt("Samuraispeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 29)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Grenadespeedlevel");
                PlayerPrefs.SetInt("Grenadespeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 37)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Bazookaspeedlevel");
                PlayerPrefs.SetInt("Bazookaspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 13)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Girlstudentspeedlevel");
                PlayerPrefs.SetInt("Girlstudentspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 23)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Constructorspeedlevel");
                PlayerPrefs.SetInt("Constructorspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 6)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Viking2speedlevel");
                PlayerPrefs.SetInt("Viking2speedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 11)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Nursespeedlevel");
                PlayerPrefs.SetInt("Nursespeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 3)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Teacherspeedlevel");
                PlayerPrefs.SetInt("Teacherspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 4)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("BaseballBallspeedlevel");
                PlayerPrefs.SetInt("BaseballBallspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }

        }

        if (selectedCharacterIndex == 32)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Girlninjaspeedlevel");
                PlayerPrefs.SetInt("Girlninjaspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 5)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Basketballspeedlevel");
                PlayerPrefs.SetInt("Basketballspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 17)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Piratespeedlevel");
                PlayerPrefs.SetInt("Piratespeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 33)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Piratecaptainspeedlevel");
                PlayerPrefs.SetInt("Piratecaptainspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 7)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Artistspeedlevel");
                PlayerPrefs.SetInt("Artistspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 34)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Rockerspeedlevel");
                PlayerPrefs.SetInt("Rockerspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 41)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Vampirespeedlevel");
                PlayerPrefs.SetInt("Vampirespeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 15)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Demonspeedlevel");
                PlayerPrefs.SetInt("Demonspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 31)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Englandsoldierspeedlevel");
                PlayerPrefs.SetInt("Englandsoldierspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 40)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Gangsterbossspeedlevel");
                PlayerPrefs.SetInt("Gangsterbossspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 16)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Indianspeedlevel");
                PlayerPrefs.SetInt("Indianspeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 8)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Policespeedlevel");
                PlayerPrefs.SetInt("Policespeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }

        if (selectedCharacterIndex == 9)
        {
            if (PlayerPrefs.GetInt("TokenAmount") >= speedtoken)
            {
                SpeedButton.interactable = true;
                speedTemp = PlayerPrefs.GetInt("Skispeedlevel");
                PlayerPrefs.SetInt("Skispeedlevel", speedTemp += 1);
                tokenAmount -= speedtoken;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }
            else
            {
                SpeedButton.interactable = false;
            }
        }
    }

    public void BuyCharacter()
    {
        if (goldAmount >= BuyPrice)
        {
            if (selectedCharacterIndex == 14)
            {
                PlayerPrefs.SetInt("SniperLocked", 1);
            }
            if (selectedCharacterIndex == 24)
            {
                PlayerPrefs.SetInt("ShotgunLocked", 1);
            }
            if (selectedCharacterIndex == 28)
            {
                PlayerPrefs.SetInt("RifleLocked", 1);
            }
            if (selectedCharacterIndex == 39)
            {
                PlayerPrefs.SetInt("MinigunLocked", 1);
            }
            if (selectedCharacterIndex == 30)
            {
                PlayerPrefs.SetInt("TommygunLocked", 1);
            }
            if (selectedCharacterIndex == 12)
            {
                PlayerPrefs.SetInt("FisherLocked", 1);
            }
            if (selectedCharacterIndex == 35)
            {
                PlayerPrefs.SetInt("LaserLocked", 1);
            }
            if (selectedCharacterIndex == 10)
            {
                PlayerPrefs.SetInt("ChefLocked", 1);
            }
            if (selectedCharacterIndex == 1)
            {
                PlayerPrefs.SetInt("MineLocked", 1);
            }
            if (selectedCharacterIndex == 22)
            {
                PlayerPrefs.SetInt("NinjaLocked", 1);
            }
            if (selectedCharacterIndex == 21)
            {
                PlayerPrefs.SetInt("AxeLocked", 1);
            }
            if (selectedCharacterIndex == 2)
            {
                PlayerPrefs.SetInt("RobberLocked", 1);
            }
            if (selectedCharacterIndex == 20)
            {
                PlayerPrefs.SetInt("SpartaLocked", 1);
            }
            if (selectedCharacterIndex == 36)
            {
                PlayerPrefs.SetInt("BoneLocked", 1);
            }
            if (selectedCharacterIndex == 19)
            {
                PlayerPrefs.SetInt("LaserswordLocked", 1);
            }
            if (selectedCharacterIndex == 38)
            {
                PlayerPrefs.SetInt("LasergunLocked", 1);
            }
            if (selectedCharacterIndex == 27)
            {
                PlayerPrefs.SetInt("FirewizardLocked", 1);
            }
            if (selectedCharacterIndex == 25)
            {
                PlayerPrefs.SetInt("PoisonwizardLocked", 1);
            }
            if (selectedCharacterIndex == 26)
            {
                PlayerPrefs.SetInt("ElectricwizardLocked", 1);
            }
            if (selectedCharacterIndex == 18)
            {
                PlayerPrefs.SetInt("SamuraiLocked", 1);
            }
            if (selectedCharacterIndex == 29)
            {
                PlayerPrefs.SetInt("GrenadeLocked", 1);
            }
            if (selectedCharacterIndex == 37)
            {
                PlayerPrefs.SetInt("BazookaLocked", 1);
            }
            if (selectedCharacterIndex == 13)
            {
                PlayerPrefs.SetInt("GirlstudentLocked", 1);
            }
            if (selectedCharacterIndex == 23)
            {
                PlayerPrefs.SetInt("ConstructorLocked", 1);
            }
            if (selectedCharacterIndex == 6)
            {
                PlayerPrefs.SetInt("Viking2Locked", 1);
            }
            if (selectedCharacterIndex == 11)
            {
                PlayerPrefs.SetInt("NurseLocked", 1);
            }
            if (selectedCharacterIndex == 3)
            {
                PlayerPrefs.SetInt("TeacherLocked", 1);
            }
            if (selectedCharacterIndex == 4)
            {
                PlayerPrefs.SetInt("BaseballBallLocked", 1);
            }
            if (selectedCharacterIndex == 32)
            {
                PlayerPrefs.SetInt("GirlninjaLocked", 1);
            }
            if (selectedCharacterIndex == 5)
            {
                PlayerPrefs.SetInt("BasketballLocked", 1);
            }
            if (selectedCharacterIndex == 17)
            {
                PlayerPrefs.SetInt("PirateLocked", 1);
            }
            if (selectedCharacterIndex == 33)
            {
                PlayerPrefs.SetInt("PiratecaptainLocked", 1);
            }
            if (selectedCharacterIndex == 7)
            {
                PlayerPrefs.SetInt("ArtistLocked", 1);
            }
            if (selectedCharacterIndex == 34)
            {
                PlayerPrefs.SetInt("RockerLocked", 1);
            }
            if (selectedCharacterIndex == 41)
            {
                PlayerPrefs.SetInt("VampireLocked", 1);
            }
            if (selectedCharacterIndex == 15)
            {
                PlayerPrefs.SetInt("DemonLocked", 1);
            }
            if (selectedCharacterIndex == 31)
            {
                PlayerPrefs.SetInt("EnglandsoldierLocked", 1);
            }
            if (selectedCharacterIndex == 40)
            {
                PlayerPrefs.SetInt("GangsterbossLocked", 1);
            }
            if (selectedCharacterIndex == 16)
            {
                PlayerPrefs.SetInt("IndianLocked", 1);
            }
            if (selectedCharacterIndex == 8)
            {
                PlayerPrefs.SetInt("PoliceLocked", 1);
            }
            if (selectedCharacterIndex == 9)
            {
                PlayerPrefs.SetInt("SkiLocked", 1);
            }

            Buy.interactable = true;
            goldAmount -= BuyPrice;
            PlayerPrefs.SetInt("GoldAmount", goldAmount);
            UpdateCharacterSelectionUI();
            UpdateLevels();
        }
        else
        {
            Buy.interactable = false;
        }
    }

    private void UpdateCharacterSelectionUI()
    {
        characterName.text = characterList[selectedCharacterIndex].characterName;
        characterPrice.text = characterList[selectedCharacterIndex].GoldPrice.ToString();
        BuyPrice = characterList[selectedCharacterIndex].GoldPrice;
        backgroundColor.color = characterList[selectedCharacterIndex].characterColor;
        desiredColor = characterList[selectedCharacterIndex].characterColor;



        if (selectedCharacterIndex == 0)
        {
            GoButton.interactable = true;
            BuyButton.SetActive(false);
            LockPanel.SetActive(false);
            characterSplash.sprite = characterList[selectedCharacterIndex].splash;

            AttackLevel = PlayerPrefs.GetInt("Pistolattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Pistolhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Pistolspeedlevel");

            attacktoken = pistoltoken;
            healthtoken = pistoltoken;
            speedtoken = pistoltoken;

            AttackText.text = (Pistol_Bullet.pistoldamage + PlayerPrefs.GetInt("Pistolattacklevel") * Pistol_Bullet.plusdamage).ToString();
            HealthText.text = (Move2.pistolHealthAmount + PlayerPrefs.GetInt("Pistolhealthlevel") * 50).ToString();
            SpeedText.text = (Move2.speed + PlayerPrefs.GetInt("Pistolspeedlevel") * 4).ToString();

            AttackButton.interactable = true;
            HealthButton.interactable = true;
            SpeedButton.interactable = true;

            if (PlayerPrefs.GetInt("Pistolattacklevel") < 10)
            {
                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
            }
            else
            {
                AttackButton2.SetActive(false);
                AttackMax.SetActive(true);
            }


            if (PlayerPrefs.GetInt("Pistolhealthlevel") < 10)
            {
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
            }
            else
            {
                HealthButton2.SetActive(false);
                HealthMax.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Pistolspeedlevel") < 10)
            {
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);
            }
            else
            {
                SpeedButton2.SetActive(false);
                SpeedMax.SetActive(true);
            }
        }

        if (selectedCharacterIndex == 14)
        {
            AttackLevel = PlayerPrefs.GetInt("Sniperattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Sniperhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Sniperspeedlevel");

            attacktoken = snipertoken;
            healthtoken = snipertoken;
            speedtoken = snipertoken;

            AttackText.text = (Sniper_Bullet.sniperdamage + PlayerPrefs.GetInt("Sniperattacklevel") * Sniper_Bullet.plusdamage).ToString();
            HealthText.text = (Sniper_Script.sniperHealthAmount + PlayerPrefs.GetInt("Sniperhealthlevel") * 50).ToString();
            SpeedText.text = (Sniper_Script.speed + PlayerPrefs.GetInt("Sniperspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("SniperLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Sniperattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Sniperhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Sniperspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 24)
        {
            AttackLevel = PlayerPrefs.GetInt("Shotgunattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Shotgunhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Shotgunspeedlevel");

            attacktoken = cowboytoken;
            healthtoken = cowboytoken;
            speedtoken = cowboytoken;

            AttackText.text = (Shotgun_Bullet.shotgundamage + PlayerPrefs.GetInt("Shotgunattacklevel") * Shotgun_Bullet.plusdamage).ToString();
            HealthText.text = (Shotgun_Script.shotgunHealthAmount + PlayerPrefs.GetInt("Shotgunhealthlevel") * 50).ToString();
            SpeedText.text = (Shotgun_Script.speed + PlayerPrefs.GetInt("Shotgunspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("ShotgunLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Shotgunattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Shotgunhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Shotgunspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 28)
        {
            AttackLevel = PlayerPrefs.GetInt("Rifleattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Riflehealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Riflespeedlevel");

            attacktoken = soldiertoken;
            healthtoken = soldiertoken;
            speedtoken = soldiertoken;

            AttackText.text = (Rifle_Bullet.rifledamage + PlayerPrefs.GetInt("Rifleattacklevel") * Rifle_Bullet.plusdamage).ToString();
            HealthText.text = (Rifle_Script.rifleHealthAmount + PlayerPrefs.GetInt("Riflehealthlevel") * 50).ToString();
            SpeedText.text = (Rifle_Script.speed + PlayerPrefs.GetInt("Riflespeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("RifleLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Rifleattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Riflehealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Riflespeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 39)
        {
            AttackLevel = PlayerPrefs.GetInt("Minigunattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Minigunhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Minigunspeedlevel");

            attacktoken = miniguntoken;
            healthtoken = miniguntoken;
            speedtoken = miniguntoken;

            AttackText.text = (Minigun_Bullet.minigundamage + PlayerPrefs.GetInt("Minigunattacklevel") * Minigun_Bullet.plusdamage).ToString();
            HealthText.text = (Minigun_Script.minigunHealthAmount + PlayerPrefs.GetInt("Minigunhealthlevel") * 50).ToString();
            SpeedText.text = (Minigun_Script.speed + PlayerPrefs.GetInt("Minigunspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("MinigunLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Minigunattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Minigunhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Minigunspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 30)
        {
            AttackLevel = PlayerPrefs.GetInt("Tommyattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Tommyhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Tommyspeedlevel");

            attacktoken = gangstertoken;
            healthtoken = gangstertoken;
            speedtoken = gangstertoken;

            AttackText.text = (Tommy_Bullet.tommydamage + PlayerPrefs.GetInt("Tommyattacklevel") * Tommy_Bullet.plusdamage).ToString();
            HealthText.text = (Tommy_Script.tommyHealthAmount + PlayerPrefs.GetInt("Tommyhealthlevel") * 50).ToString();
            SpeedText.text = (Tommy_Script.speed + PlayerPrefs.GetInt("Tommyspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("TommygunLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Tommyattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Tommyhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Tommyspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 12)
        {
            AttackLevel = PlayerPrefs.GetInt("Fisherattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Fisherhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Fisherspeedlevel");

            attacktoken = fishertoken;
            healthtoken = fishertoken;
            speedtoken = fishertoken;

            AttackText.text = (Harpoon_Bullet.harpoondamage + PlayerPrefs.GetInt("Fisherattacklevel") * Harpoon_Bullet.plusdamage).ToString();
            HealthText.text = (Harpoon_Script.harpoonHealthAmount + PlayerPrefs.GetInt("Fisherhealthlevel") * 50).ToString();
            SpeedText.text = (Harpoon_Script.speed + PlayerPrefs.GetInt("Fisherspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("FisherLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Fisherattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Fisherhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Fisherspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 35)
        {
            AttackLevel = PlayerPrefs.GetInt("Laserattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Laserhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Laserspeedlevel");

            attacktoken = lasertoken;
            healthtoken = lasertoken;
            speedtoken = lasertoken;

            AttackText.text = (Laser_Bullet.laserdamage + PlayerPrefs.GetInt("Laserattacklevel") * Laser_Bullet.plusdamage).ToString();
            HealthText.text = (Laser_Script.laserHealthAmount + PlayerPrefs.GetInt("Laserhealthlevel") * 50).ToString();
            SpeedText.text = (Laser_Script.speed + PlayerPrefs.GetInt("Laserspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("LaserLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Laserattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Laserhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Laserspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 10)
        {
            AttackLevel = PlayerPrefs.GetInt("Chefattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Chefhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Chefspeedlevel");

            attacktoken = cheftoken;
            healthtoken = cheftoken;
            speedtoken = cheftoken;

            AttackText.text = (Chef_Bullet.chefdamage + PlayerPrefs.GetInt("Chefattacklevel") * Chef_Bullet.plusdamage).ToString();
            HealthText.text = (Chef_Script.chefHealthAmount + PlayerPrefs.GetInt("Chefhealthlevel") * 50).ToString();
            SpeedText.text = (Chef_Script.speed + PlayerPrefs.GetInt("Chefspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("ChefLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Chefattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Chefhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Chefspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        
        if (selectedCharacterIndex == 1)
        {
            AttackLevel = PlayerPrefs.GetInt("Mineattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Minehealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Minespeedlevel");

            attacktoken = minetoken;
            healthtoken = minetoken;
            speedtoken = minetoken;

            AttackText.text = (Mine_Attack.minedamage + PlayerPrefs.GetInt("Mineattacklevel") * Mine_Attack.plusdamage).ToString();
            HealthText.text = (MineWorker_Script.mineHealthAmount + PlayerPrefs.GetInt("Minehealthlevel") * 50).ToString();
            SpeedText.text = (MineWorker_Script.speed + PlayerPrefs.GetInt("Minespeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("MineLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Mineattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Minehealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Minespeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }


        if (selectedCharacterIndex == 22)
        {
            AttackLevel = PlayerPrefs.GetInt("Ninjaattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Ninjahealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Ninjaspeedlevel");

            attacktoken = ninjatoken;
            healthtoken = ninjatoken;
            speedtoken = ninjatoken;

            AttackText.text = (Ninja_Bullet.ninjadamage + PlayerPrefs.GetInt("Ninjaattacklevel") * Ninja_Bullet.plusdamage).ToString();
            HealthText.text = (Ninja_Script.ninjaHealthAmount + PlayerPrefs.GetInt("Ninjahealthlevel") * 50).ToString();
            SpeedText.text = (Ninja_Script.speed + PlayerPrefs.GetInt("Ninjaspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("NinjaLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Ninjaattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Ninjahealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Ninjaspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 21)
        {
            AttackLevel = PlayerPrefs.GetInt("Axeattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Axehealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Axespeedlevel");

            attacktoken = axetoken;
            healthtoken = axetoken;
            speedtoken = axetoken;

            AttackText.text = (Axe_Attack.axedamage + PlayerPrefs.GetInt("Axeattacklevel") * Axe_Attack.plusdamage).ToString();
            HealthText.text = (Axe_Script.axeHealthAmount + PlayerPrefs.GetInt("Axehealthlevel") * 50).ToString();
            SpeedText.text = (Axe_Script.speed + PlayerPrefs.GetInt("Axespeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("AxeLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Axeattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Axehealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Axespeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 2)
        {
            AttackLevel = PlayerPrefs.GetInt("Robberattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Robberhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Robberspeedlevel");

            attacktoken = robbertoken;
            healthtoken = robbertoken;
            speedtoken = robbertoken;

            AttackText.text = (Robber_Attack.robberdamage + PlayerPrefs.GetInt("Robberattacklevel") * Robber_Attack.plusdamage).ToString();
            HealthText.text = (Robber_Script.robberHealthAmount + PlayerPrefs.GetInt("Robberhealthlevel") * 50).ToString();
            SpeedText.text = (Robber_Script.speed + PlayerPrefs.GetInt("Robberspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("RobberLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Robberattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Robberhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Robberspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 20)
        {
            AttackLevel = PlayerPrefs.GetInt("Spartaattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Spartahealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Spartaspeedlevel");

            attacktoken = spartatoken;
            healthtoken = spartatoken;
            speedtoken = spartatoken;

            AttackText.text = (Sparta_Attack.spartadamage + PlayerPrefs.GetInt("Spartaattacklevel") * Sparta_Attack.plusdamage).ToString();
            HealthText.text = (Sparta_Script.spartaHealthAmount + PlayerPrefs.GetInt("Spartahealthlevel") * 50).ToString();
            SpeedText.text = (Sparta_Script.speed + PlayerPrefs.GetInt("Spartaspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("SpartaLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Spartaattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Spartahealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Spartaspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 36)
        {
            AttackLevel = PlayerPrefs.GetInt("Boneattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Bonehealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Bonespeedlevel");

            attacktoken = bonetoken;
            healthtoken = bonetoken;
            speedtoken = bonetoken;

            AttackText.text = (Bone_Bullet.bonedamage + PlayerPrefs.GetInt("Boneattacklevel") * Bone_Bullet.plusdamage).ToString();
            HealthText.text = (Bone_Script.boneHealthAmount + PlayerPrefs.GetInt("Bonehealthlevel") * 50).ToString();
            SpeedText.text = (Bone_Script.speed + PlayerPrefs.GetInt("Bonespeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("BoneLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Boneattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Bonehealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Bonespeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 19)
        {
            AttackLevel = PlayerPrefs.GetInt("Laserswordattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Laserswordhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Laserswordspeedlevel");

            attacktoken = laserswordtoken;
            healthtoken = laserswordtoken;
            speedtoken = laserswordtoken;

            AttackText.text = (Lasersword_Attack.lasersworddamage + PlayerPrefs.GetInt("Laserswordattacklevel") * Lasersword_Attack.plusdamage).ToString();
            HealthText.text = (Lasersword_Script.laserswordHealthAmount + PlayerPrefs.GetInt("Laserswordhealthlevel") * 50).ToString();
            SpeedText.text = (Lasersword_Script.speed + PlayerPrefs.GetInt("Laserswordspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("LaserswordLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Laserswordattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Laserswordhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Laserswordspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 38)
        {
            AttackLevel = PlayerPrefs.GetInt("Lasergunattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Lasergunhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Lasergunspeedlevel");

            attacktoken = laserguntoken;
            healthtoken = laserguntoken;
            speedtoken = laserguntoken;

            AttackText.text = (LaserGun_Attack.lasergundamage + PlayerPrefs.GetInt("Lasergunattacklevel") * LaserGun_Attack.plusdamage).ToString();
            HealthText.text = (LaserGun_Script.lasergunHealthAmount + PlayerPrefs.GetInt("Lasergunhealthlevel") * 50).ToString();
            SpeedText.text = (LaserGun_Script.speed + PlayerPrefs.GetInt("Lasergunspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("LasergunLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Lasergunattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Lasergunhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Lasergunspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 27)
        {
            AttackLevel = PlayerPrefs.GetInt("Firewizardattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Firewizardhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Firewizardspeedlevel");

            attacktoken = firewizardtoken;
            healthtoken = firewizardtoken;
            speedtoken = firewizardtoken;

            AttackText.text = (Firewizard_Attack.firewizarddamage + PlayerPrefs.GetInt("Firewizardattacklevel") * Firewizard_Attack.plusdamage).ToString();
            HealthText.text = (Firewizard_Script.firewizardHealthAmount + PlayerPrefs.GetInt("Firewizardhealthlevel") * 50).ToString();
            SpeedText.text = (Firewizard_Script.speed + PlayerPrefs.GetInt("Firewizardspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("FirewizardLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Firewizardattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Firewizardhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Firewizardspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 25)
        {
            AttackLevel = PlayerPrefs.GetInt("Poisonwizardattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Poisonwizardhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Poisonwizardspeedlevel");

            attacktoken = poisonwizardtoken;
            healthtoken = poisonwizardtoken;
            speedtoken = poisonwizardtoken;

            AttackText.text = (Poisonwizard_Attack.poisonwizarddamage + PlayerPrefs.GetInt("Poisonwizardattacklevel") * Poisonwizard_Attack.plusdamage).ToString();
            HealthText.text = (Poisonwizard_Script.poisonwizardHealthAmount + PlayerPrefs.GetInt("Poisonwizardhealthlevel") * 50).ToString();
            SpeedText.text = (Poisonwizard_Script.speed + PlayerPrefs.GetInt("Poisonwizardspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("PoisonwizardLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Poisonwizardattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Poisonwizardhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Poisonwizardspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }


        if (selectedCharacterIndex == 26)
        {
            AttackLevel = PlayerPrefs.GetInt("Electricwizardattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Electricwizardhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Electricwizardspeedlevel");

            attacktoken = electricwizardtoken;
            healthtoken = electricwizardtoken;
            speedtoken = electricwizardtoken;

            AttackText.text = (ElectricWizard_Attack.electricwizarddamage + PlayerPrefs.GetInt("Electricwizardattacklevel") * ElectricWizard_Attack.plusdamage).ToString();
            HealthText.text = (ElectricWizard_Script.electricwizardHealthAmount + PlayerPrefs.GetInt("Electricwizardhealthlevel") * 50).ToString();
            SpeedText.text = (ElectricWizard_Script.speed + PlayerPrefs.GetInt("Electricwizardhealthlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("ElectricwizardLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Electricwizardattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Electricwizardhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Electricwizardspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 18)
        {
            AttackLevel = PlayerPrefs.GetInt("Samuraiattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Samuraihealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Samuraispeedlevel");

            attacktoken = samuraitoken;
            healthtoken = samuraitoken;
            speedtoken = samuraitoken;

            AttackText.text = (Samurai_Attack.samuraidamage + PlayerPrefs.GetInt("Samuraiattacklevel") * Samurai_Attack.plusdamage).ToString();
            HealthText.text = (Samurai_Script.samuraiHealthAmount + PlayerPrefs.GetInt("Samuraihealthlevel") * 50).ToString();
            SpeedText.text = (Samurai_Script.speed + PlayerPrefs.GetInt("Samuraispeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("SamuraiLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Samuraiattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Samuraihealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Samuraispeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 29)
        {
            AttackLevel = PlayerPrefs.GetInt("Grenadeattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Grenadehealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Grenadespeedlevel");

            attacktoken = grenadetoken;
            healthtoken = grenadetoken;
            speedtoken = grenadetoken;

            AttackText.text = (Grenade_Attack.grenadedamage + PlayerPrefs.GetInt("Grenadeattacklevel") * Grenade_Attack.plusdamage).ToString();
            HealthText.text = (Grenademan_Script.grenadeHealthAmount + PlayerPrefs.GetInt("Grenadehealthlevel") * 50).ToString();
            SpeedText.text = (Grenademan_Script.speed + PlayerPrefs.GetInt("Grenadespeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("GrenadeLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Grenadeattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Grenadehealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Grenadespeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 37)
        {
            AttackLevel = PlayerPrefs.GetInt("Bazookaattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Bazookahealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Bazookaspeedlevel");

            attacktoken = bazookatoken;
            healthtoken = bazookatoken;
            speedtoken = bazookatoken;

            AttackText.text = (Bazooka_Bullet.bazookadamage + PlayerPrefs.GetInt("Bazookaattacklevel") * Bazooka_Bullet.plusdamage).ToString();
            HealthText.text = (Bazooka_Script.bazookaHealthAmount + PlayerPrefs.GetInt("Bazookahealthlevel") * 50).ToString();
            SpeedText.text = (Bazooka_Script.speed + PlayerPrefs.GetInt("Bazookaspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("BazookaLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Bazookaattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Bazookahealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Bazookaspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 13)
        {
            AttackLevel = PlayerPrefs.GetInt("Girlstudentattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Girlstudenthealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Girlstudentspeedlevel");

            attacktoken = girlstudenttoken;
            healthtoken = girlstudenttoken;
            speedtoken = girlstudenttoken;

            AttackText.text = (GirlStudent_Bullet.girlstudentdamage + PlayerPrefs.GetInt("Girlstudentattacklevel") * GirlStudent_Bullet.plusdamage).ToString();
            HealthText.text = (GirlStudent_Script.girlstudentHealthAmount + PlayerPrefs.GetInt("Girlstudenthealthlevel") * 50).ToString();
            SpeedText.text = (GirlStudent_Script.speed + PlayerPrefs.GetInt("Girlstudentspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("GirlstudentLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Girlstudentattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Girlstudenthealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Girlstudentspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 23)
        {
            AttackLevel = PlayerPrefs.GetInt("Constructorattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Constructorhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Constructorspeedlevel");

            attacktoken = constructortoken;
            healthtoken = constructortoken;
            speedtoken = constructortoken;

            AttackText.text = (Constructor_Attack.constructordamage + PlayerPrefs.GetInt("Constructorattacklevel") * Constructor_Attack.plusdamage).ToString();
            HealthText.text = (Constructor_Script.constructorHealthAmount + PlayerPrefs.GetInt("Constructorhealthlevel") * 50).ToString();
            SpeedText.text = (Constructor_Script.speed + PlayerPrefs.GetInt("Constructorspeedlevel") * 4).ToString();


            if (PlayerPrefs.GetInt("ConstructorLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Constructorattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Constructorhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Constructorspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }


        if (selectedCharacterIndex == 6)
        {
            AttackLevel = PlayerPrefs.GetInt("Viking2attacklevel");
            HealthLevel = PlayerPrefs.GetInt("Viking2healthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Viking2speedlevel");

            attacktoken = viking2token;
            healthtoken = viking2token;
            speedtoken = viking2token;

            AttackText.text = (Viking2_Attack.viking2damage + PlayerPrefs.GetInt("Viking2attacklevel") * Viking2_Attack.plusdamage).ToString();
            HealthText.text = (Viking2_Script.viking2HealthAmount + PlayerPrefs.GetInt("Viking2healthlevel") * 50).ToString();
            SpeedText.text = (Viking2_Script.speed + PlayerPrefs.GetInt("Viking2speedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("Viking2Locked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Viking2attacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Viking2healthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Viking2speedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 11)
        {
            AttackLevel = PlayerPrefs.GetInt("Nurseattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Nursehealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Nursespeedlevel");

            attacktoken = nursetoken;
            healthtoken = nursetoken;
            speedtoken = nursetoken;

            AttackText.text = (Nurse_Attack.nursedamage + PlayerPrefs.GetInt("Nurseattacklevel") * Nurse_Attack.plusdamage).ToString();
            HealthText.text = (Nurse_Script.nurseHealthAmount + PlayerPrefs.GetInt("Nursehealthlevel") * 50).ToString();
            SpeedText.text = (Nurse_Script.speed + PlayerPrefs.GetInt("Nursespeedlevel") * 4).ToString();


            if (PlayerPrefs.GetInt("NurseLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Nurseattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Nursehealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Nursespeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 3)
        {
            AttackLevel = PlayerPrefs.GetInt("Teacherattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Teacherhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Teacherspeedlevel");

            attacktoken = teachertoken;
            healthtoken = teachertoken;
            speedtoken = teachertoken;

            AttackText.text = (Teacher_Attack.teacherdamage + PlayerPrefs.GetInt("Teacherattacklevel") * Teacher_Attack.plusdamage).ToString();
            HealthText.text = (Teacher_Script.teacherHealthAmount + PlayerPrefs.GetInt("Teacherhealthlevel") * 50).ToString();
            SpeedText.text = (Teacher_Script.speed + PlayerPrefs.GetInt("Teacherspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("TeacherLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Teacherattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Teacherhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Teacherspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }


        if (selectedCharacterIndex == 4)
        {
            AttackLevel = PlayerPrefs.GetInt("BaseballBallattacklevel");
            HealthLevel = PlayerPrefs.GetInt("BaseballBallhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("BaseballBallspeedlevel");

            attacktoken = baseballballtoken;
            healthtoken = baseballballtoken;
            speedtoken = baseballballtoken;

            AttackText.text = (BaseballBall_Attack.baseballBalldamage + PlayerPrefs.GetInt("BaseballBallattacklevel") * BaseballBall_Attack.plusdamage).ToString();
            HealthText.text = (BaseballBall_Script.baseballBallHealthAmount + PlayerPrefs.GetInt("BaseballBallhealthlevel") * 50).ToString();
            SpeedText.text = (BaseballBall_Script.speed + PlayerPrefs.GetInt("BaseballBallspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("BaseballBallLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("BaseballBallattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("BaseballBallhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("BaseballBallspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 32)
        {
            AttackLevel = PlayerPrefs.GetInt("Girlninjaattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Girlninjahealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Girlninjaspeedlevel");

            attacktoken = girlninjatoken;
            healthtoken = girlninjatoken;
            speedtoken = girlninjatoken;

            AttackText.text = (GirlNinja_Attack.girlninjadamage + PlayerPrefs.GetInt("Girlninjaattacklevel") * GirlNinja_Attack.plusdamage).ToString();
            HealthText.text = (GirlNinja_Script.girlninjaHealthAmount + PlayerPrefs.GetInt("Girlninjahealthlevel") * 50).ToString();
            SpeedText.text = (GirlNinja_Script.speed + PlayerPrefs.GetInt("Girlninjaspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("GirlninjaLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Girlninjaattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Girlninjahealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Girlninjaspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 5)
        {
            AttackLevel = PlayerPrefs.GetInt("Basketballattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Basketballhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Basketballspeedlevel");

            attacktoken = basketballtoken;
            healthtoken = basketballtoken;
            speedtoken = basketballtoken;

            AttackText.text = (Basketball_Attack.basketballdamage + PlayerPrefs.GetInt("Basketballattacklevel") * Basketball_Attack.plusdamage).ToString();
            HealthText.text = (Basketball_Script.basketballHealthAmount + PlayerPrefs.GetInt("Basketballhealthlevel") * 50).ToString();
            SpeedText.text = (Basketball_Script.speed + PlayerPrefs.GetInt("Basketballspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("BasketballLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Basketballattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Basketballhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Basketballspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }


        if (selectedCharacterIndex == 17)
        {
            AttackLevel = PlayerPrefs.GetInt("Pirateattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Piratehealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Piratespeedlevel");

            attacktoken = piratetoken;
            healthtoken = piratetoken;
            speedtoken = piratetoken;

            AttackText.text = (Pirate_Attack.piratedamage + PlayerPrefs.GetInt("Pirateattacklevel") * Pirate_Attack.plusdamage).ToString();
            HealthText.text = (Pirate_Script.pirateHealthAmount + PlayerPrefs.GetInt("Piratehealthlevel") * 50).ToString();
            SpeedText.text = (Pirate_Script.speed + PlayerPrefs.GetInt("Piratespeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("PirateLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Pirateattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Piratehealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Piratespeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 33)
        {
            AttackLevel = PlayerPrefs.GetInt("Piratecaptainattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Piratecaptainhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Piratecaptainspeedlevel");

            attacktoken = piratecaptaintoken;
            healthtoken = piratecaptaintoken;
            speedtoken = piratecaptaintoken;

            AttackText.text = (PirateCaptain_Attack.piratecaptaindamage + PlayerPrefs.GetInt("Piratecaptainattacklevel") * PirateCaptain_Attack.plusdamage).ToString();
            HealthText.text = (PirateCaptain_Script.piratecaptainHealthAmount + PlayerPrefs.GetInt("Piratecaptainhealthlevel") * 50).ToString();
            SpeedText.text = (PirateCaptain_Script.speed + PlayerPrefs.GetInt("Piratecaptainspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("PiratecaptainLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Piratecaptainattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Piratecaptainhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Piratecaptainspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 7)
        {
            AttackLevel = PlayerPrefs.GetInt("Artistattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Artisthealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Artistspeedlevel");

            attacktoken = artisttoken;
            healthtoken = artisttoken;
            speedtoken = artisttoken;

            AttackText.text = (Artist_Attack.artistdamage + PlayerPrefs.GetInt("Artistattacklevel") * Artist_Attack.plusdamage).ToString();
            HealthText.text = (Artist_Script.artistHealthAmount + PlayerPrefs.GetInt("Artisthealthlevel") * 50).ToString();
            SpeedText.text = (Artist_Script.speed + PlayerPrefs.GetInt("Artistspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("ArtistLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Artistattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Artisthealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Artistspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 34)
        {
            AttackLevel = PlayerPrefs.GetInt("Rockerattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Rockerhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Rockerspeedlevel");

            attacktoken = rockertoken;
            healthtoken = rockertoken;
            speedtoken = rockertoken;

            AttackText.text = (Rocker_Attack.rockerdamage + PlayerPrefs.GetInt("Rockerattacklevel") * Rocker_Attack.plusdamage).ToString();
            HealthText.text = (Rocker_Script.rockerHealthAmount + PlayerPrefs.GetInt("Rockerhealthlevel") * 50).ToString();
            SpeedText.text = (Rocker_Script.speed + PlayerPrefs.GetInt("Rockerspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("RockerLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Rockerattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Rockerhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Rockerspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 41)
        {
            AttackLevel = PlayerPrefs.GetInt("Vampireattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Vampirehealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Vampirespeedlevel");

            attacktoken = vampiretoken;
            healthtoken = vampiretoken;
            speedtoken = vampiretoken;

            AttackText.text = (Vampire_Attack.vampiredamage + PlayerPrefs.GetInt("Vampireattacklevel") * Vampire_Attack.plusdamage).ToString();
            HealthText.text = (Vampire_Script.vampireHealthAmount + PlayerPrefs.GetInt("Vampirehealthlevel") * 50).ToString();
            SpeedText.text = (Vampire_Script.speed + PlayerPrefs.GetInt("Vampirespeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("VampireLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Vampireattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Vampirehealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Vampirespeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 15)
        {
            AttackLevel = PlayerPrefs.GetInt("Demonattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Demonhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Demonspeedlevel");

            attacktoken = demontoken;
            healthtoken = demontoken;
            speedtoken = demontoken;

            AttackText.text = (Demon_Attack.demondamage + PlayerPrefs.GetInt("Demonattacklevel") * Demon_Attack.plusdamage).ToString();
            HealthText.text = (Demon_Script.demonHealthAmount + PlayerPrefs.GetInt("Demonhealthlevel") * 50).ToString();
            SpeedText.text = (Demon_Script.speed + PlayerPrefs.GetInt("Demonspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("DemonLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Demonattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Demonhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Demonspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 31)
        {
            AttackLevel = PlayerPrefs.GetInt("Englandsoldierattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Englandsoldierhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Englandsoldierspeedlevel");

            attacktoken = englandsoldiertoken;
            healthtoken = englandsoldiertoken;
            speedtoken = englandsoldiertoken;

            AttackText.text = (EnglandSoldier_Attack.englandsoldierdamage + PlayerPrefs.GetInt("Englandsoldierattacklevel") * EnglandSoldier_Attack.plusdamage).ToString();
            HealthText.text = (EnglandSoldier_Script.englandsoldierHealthAmount + PlayerPrefs.GetInt("Englandsoldierhealthlevel") * 50).ToString();
            SpeedText.text = (EnglandSoldier_Script.speed + PlayerPrefs.GetInt("Englandsoldierspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("EnglandsoldierLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Englandsoldierattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Englandsoldierhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Englandsoldierspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 40)
        {
            AttackLevel = PlayerPrefs.GetInt("Gangsterbossattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Gangsterbosshealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Gangsterbossspeedlevel");

            attacktoken = gangsterbosstoken;
            healthtoken = gangsterbosstoken;
            speedtoken = gangsterbosstoken;

            AttackText.text = (GangsterBoss_Attack.gangsterbossdamage + PlayerPrefs.GetInt("Gangsterbossattacklevel") * GangsterBoss_Attack.plusdamage).ToString();
            HealthText.text = (GangsterBoss_Script.gangsterbossHealthAmount + PlayerPrefs.GetInt("Gangsterbosshealthlevel") * 50).ToString();
            SpeedText.text = (GangsterBoss_Script.speed + PlayerPrefs.GetInt("Gangsterbossspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("GangsterbossLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Gangsterbossattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Gangsterbosshealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Gangsterbossspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 16)
        {
            AttackLevel = PlayerPrefs.GetInt("Indianattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Indianhealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Indianspeedlevel");

            attacktoken = indiantoken;
            healthtoken = indiantoken;
            speedtoken = indiantoken;

            AttackText.text = (Indian_Attack.indiandamage + PlayerPrefs.GetInt("Indianattacklevel") * Indian_Attack.plusdamage).ToString();
            HealthText.text = (Indian_Script.indianHealthAmount + PlayerPrefs.GetInt("Indianhealthlevel") * 50).ToString();
            SpeedText.text = (Indian_Script.speed + PlayerPrefs.GetInt("Indianspeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("IndianLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Indianattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Indianhealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Indianspeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 8)
        {
            AttackLevel = PlayerPrefs.GetInt("Policeattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Policehealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Policespeedlevel");

            attacktoken = policetoken;
            healthtoken = policetoken;
            speedtoken = policetoken;

            AttackText.text = (Police_Attack.policedamage + PlayerPrefs.GetInt("Policeattacklevel") * Police_Attack.plusdamage).ToString();
            HealthText.text = (Police_Script.policeHealthAmount + PlayerPrefs.GetInt("Policehealthlevel") * 50).ToString();
            SpeedText.text = (Police_Script.speed + PlayerPrefs.GetInt("Policespeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("PoliceLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Policeattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Policehealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Policespeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        if (selectedCharacterIndex == 9)
        {
            AttackLevel = PlayerPrefs.GetInt("Skiattacklevel");
            HealthLevel = PlayerPrefs.GetInt("Skihealthlevel");
            SpeedLevel = PlayerPrefs.GetInt("Skispeedlevel");

            attacktoken = skitoken;
            healthtoken = skitoken;
            speedtoken = skitoken;

            AttackText.text = (Ski_Attack.skidamage + PlayerPrefs.GetInt("Skiattacklevel") * Ski_Attack.plusdamage).ToString();
            HealthText.text = (Ski_Script.skiHealthAmount + PlayerPrefs.GetInt("Skihealthlevel") * 50).ToString();
            SpeedText.text = (Ski_Script.speed + PlayerPrefs.GetInt("Skispeedlevel") * 4).ToString();

            if (PlayerPrefs.GetInt("SkiLocked") == 1)
            {
                GoButton.interactable = true;
                BuyButton.SetActive(false);
                LockPanel.SetActive(false);
                characterSplash.sprite = characterList[selectedCharacterIndex].splash;

                AttackButton.interactable = true;
                HealthButton.interactable = true;
                SpeedButton.interactable = true;

                if (PlayerPrefs.GetInt("Skiattacklevel") < 10)
                {
                    AttackButton2.SetActive(true);
                    AttackMax.SetActive(false);
                }
                else
                {
                    AttackButton2.SetActive(false);
                    AttackMax.SetActive(true);

                }

                if (PlayerPrefs.GetInt("Skihealthlevel") < 10)
                {
                    HealthButton2.SetActive(true);
                    HealthMax.SetActive(false);
                }
                else
                {
                    HealthButton2.SetActive(false);
                    HealthMax.SetActive(true);
                }

                if (PlayerPrefs.GetInt("Skispeedlevel") < 10)
                {
                    SpeedButton2.SetActive(true);
                    SpeedMax.SetActive(false);
                }
                else
                {
                    SpeedButton2.SetActive(false);
                    SpeedMax.SetActive(true);
                }
            }
            else
            {
                AttackButton.interactable = false;
                HealthButton.interactable = false;
                SpeedButton.interactable = false;

                AttackButton2.SetActive(true);
                AttackMax.SetActive(false);
                HealthButton2.SetActive(true);
                HealthMax.SetActive(false);
                SpeedButton2.SetActive(true);
                SpeedMax.SetActive(false);

                GoButton.interactable = false;
                BuyButton.SetActive(true);
                LockPanel.SetActive(true);
                characterSplash.sprite = characterList[selectedCharacterIndex].lockedSplash;
            }
        }

        UpdateLevels();
    }

    public void UpdateLevels()
    {
        if (AttackLevel >= 1)
        {
            Attack1.color = fillColor;
        }
        else
        {
            Attack1.color = whiteColor;
        }

        if (AttackLevel >= 2)
        {
            Attack2.color = fillColor;
        }
        else
        {
            Attack2.color = whiteColor;
        }

        if (AttackLevel >= 3)
        {
            Attack3.color = fillColor;
        }
        else
        {
            Attack3.color = whiteColor;
        }

        if (AttackLevel >= 4)
        {
            Attack4.color = fillColor;
        }
        else
        {
            Attack4.color = whiteColor;
        }

        if (AttackLevel >= 5)
        {
            Attack5.color = fillColor;
        }
        else
        {
            Attack5.color = whiteColor;
        }

        if (AttackLevel >= 6)
        {
            Attack6.color = fillColor;
        }
        else
        {
            Attack6.color = whiteColor;
        }

        if (AttackLevel >= 7)
        {
            Attack7.color = fillColor;
        }
        else
        {
            Attack7.color = whiteColor;
        }

        if (AttackLevel >= 8)
        {
            Attack8.color = fillColor;
        }
        else
        {
            Attack8.color = whiteColor;
        }

        if (AttackLevel >= 9)
        {
            Attack9.color = fillColor;
        }
        else
        {
            Attack9.color = whiteColor;
        }

        if (AttackLevel >= 10)
        {
            Attack10.color = fillColor;
        }
        else
        {
            Attack10.color = whiteColor;
        }


        if (HealthLevel >= 1)
        {
            Health1.color = fillColor;
        }
        else
        {
            Health1.color = whiteColor;
        }

        if (HealthLevel >= 2)
        {
            Health2.color = fillColor;
        }
        else
        {
            Health2.color = whiteColor;
        }

        if (HealthLevel >= 3)
        {
            Health3.color = fillColor;
        }
        else
        {
            Health3.color = whiteColor;
        }

        if (HealthLevel >= 4)
        {
            Health4.color = fillColor;
        }
        else
        {
            Health4.color = whiteColor;
        }

        if (HealthLevel >= 5)
        {
            Health5.color = fillColor;
        }
        else
        {
            Health5.color = whiteColor;
        }

        if (HealthLevel >= 6)
        {
            Health6.color = fillColor;
        }
        else
        {
            Health6.color = whiteColor;
        }

        if (HealthLevel >= 7)
        {
            Health7.color = fillColor;
        }
        else
        {
            Health7.color = whiteColor;
        }

        if (HealthLevel >= 8)
        {
            Health8.color = fillColor;
        }
        else
        {
            Health8.color = whiteColor;
        }

        if (HealthLevel >= 9)
        {
            Health9.color = fillColor;
        }
        else
        {
            Health9.color = whiteColor;
        }

        if (HealthLevel >= 10)
        {
            Health10.color = fillColor;
        }
        else
        {
            Health10.color = whiteColor;
        }


        if (SpeedLevel >= 1)
        {
            Speed1.color = fillColor;
        }
        else
        {
            Speed1.color = whiteColor;
        }

        if (SpeedLevel >= 2)
        {
            Speed2.color = fillColor;
        }
        else
        {
            Speed2.color = whiteColor;
        }

        if (SpeedLevel >= 3)
        {
            Speed3.color = fillColor;
        }
        else
        {
            Speed3.color = whiteColor;
        }

        if (SpeedLevel >= 4)
        {
            Speed4.color = fillColor;
        }
        else
        {
            Speed4.color = whiteColor;
        }

        if (SpeedLevel >= 5)
        {
            Speed5.color = fillColor;
        }
        else
        {
            Speed5.color = whiteColor;
        }

        if (SpeedLevel >= 6)
        {
            Speed6.color = fillColor;
        }
        else
        {
            Speed6.color = whiteColor;
        }

        if (SpeedLevel >= 7)
        {
            Speed7.color = fillColor;
        }
        else
        {
            Speed7.color = whiteColor;
        }

        if (SpeedLevel >= 8)
        {
            Speed8.color = fillColor;
        }
        else
        {
            Speed8.color = whiteColor;
        }

        if (SpeedLevel >= 9)
        {
            Speed9.color = fillColor;
        }
        else
        {
            Speed9.color = whiteColor;
        }

        if (SpeedLevel >= 10)
        {
            Speed10.color = fillColor;
        }
        else
        {
            Speed10.color = whiteColor;
        }

    }

    [System.Serializable]
    public class CharacterSelectObject
    {
        public Sprite splash;
        public Sprite lockedSplash;
        public string characterName;
        public Color characterColor;

        public int GoldPrice;
    }
}
