using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopScript2 : MonoBehaviour
{
    int goldAmount;

    int tokenAmount;

    public TextMeshProUGUI goldAmountText;

    public TextMeshProUGUI tokenAmountText;

    public Button CharacterButton;

    int tokenPlus;

    public Button tokenButton;

    public Button tokenButton2;

    int randomintCharacter;
    int randomNumber;
    int randomNumberALot;

    int sniperLocked = 0;
    int shotgunLocked = 0;
    int rifleLocked = 0;
    int tommygunLocked = 0;
    int fisherLocked = 0;
    int chefLocked = 0;
    int mineLocked = 0;
    int ninjaLocked = 0;
    int axeLocked = 0;
    int robberLocked = 0;
    int spartaLocked = 0;
    int laserswordLocked = 0;
    int firewizardLocked = 0;
    int poisonwizardLocked = 0;
    int electricwizardLocked = 0;
    int samuraiLocked = 0;
    int grenadeLocked = 0;
    int girlstudentLocked = 0;
    int constructorLocked = 0;
    int viking2Locked = 0;
    int nurseLocked = 0;
    int teacherLocked = 0;
    int artistLocked = 0;
    int baseballBallLocked = 0;
    int basketballLocked = 0;
    int demonLocked = 0;
    int englandsoldierLocked = 0;
    int girlninjaLocked = 0;
    int indianLocked = 0;
    int pirateLocked = 0;
    int piratecaptainLocked = 0;
    int policeLocked = 0;
    int rockerLocked = 0;
    int skiLocked = 0;
    int bazookaLocked = 0;
    int boneLocked = 0;
    int laserLocked = 0;
    int lasergunLocked = 0;
    int minigunLocked = 0;
    int gangsterbossLocked = 0;
    int vampireLocked = 0;

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI characterName;
    [SerializeField] private Image characterSplash;
    [SerializeField] private TextMeshProUGUI tokenPlusText;
    [SerializeField] private Image tokenPlusImage;

    public TextMeshProUGUI newOrNotText;
    public GameObject unlockedPanel;

    public GameObject TokenPanel;

    public GameObject InformPanel;

    public GameObject goldreturn;

    public GameObject characterPopUP;

    public Sprite sniperSplash;
    public Sprite cowboySplash;
    public Sprite soldierSplash;
    public Sprite gangsterSplash;
    public Sprite fisherSplash;
    public Sprite chefSplash;
    public Sprite mineSplash;
    public Sprite ninjaSplash;
    public Sprite axeSplash;
    public Sprite robberSplash;
    public Sprite spartaSplash;
    public Sprite laserswordSplash;
    public Sprite firewizardSplash;
    public Sprite poisonwizardSplash;
    public Sprite electricwizardSplash;
    public Sprite samuraiSplash;
    public Sprite grenadeSplash;
    public Sprite girlstudentSplash;
    public Sprite constructorSplash;
    public Sprite viking2Splash;
    public Sprite nurseSplash;
    public Sprite teacherSplash;
    public Sprite artistSplash;
    public Sprite baseballBallSplash;
    public Sprite basketballSplash;
    public Sprite demonSplash;
    public Sprite englandsoldierSplash;
    public Sprite girlninjaSplash;
    public Sprite indianSplash;
    public Sprite pirateSplash;
    public Sprite piratecaptainSplash;
    public Sprite policeSplash;
    public Sprite rockerSplash;
    public Sprite skiSplash;
    public Sprite bazookaSplash;
    public Sprite boneSplash;
    public Sprite laserSplash;
    public Sprite lasergunSplash;
    public Sprite minigunSplash;
    public Sprite gangsterbossSplash;
    public Sprite vampireSplash;

    public Sprite OnetokenSplash;
    public Sprite TwotokenSplash;
    public Sprite ThreetokenSplash;
    public Sprite LotsoftokenSplash;

    public Sprite Box1;
    public Sprite Box2;
    public Sprite Box3;
    public Sprite Box4;
    public Sprite Box5;

    public Image splash;

    public float boxHealth = 8;
    public float boxDamageAmount = 1;


    void Start()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        tokenAmount = PlayerPrefs.GetInt("TokenAmount");

        sniperLocked = PlayerPrefs.GetInt("SniperLocked");
        shotgunLocked = PlayerPrefs.GetInt("ShotgunLocked");
        rifleLocked = PlayerPrefs.GetInt("RifleLocked");
        tommygunLocked = PlayerPrefs.GetInt("TommygunLocked");
        fisherLocked = PlayerPrefs.GetInt("FisherLocked");
        chefLocked = PlayerPrefs.GetInt("ChefLocked");
        mineLocked = PlayerPrefs.GetInt("MineLocked");
        ninjaLocked = PlayerPrefs.GetInt("NinjaLocked");
        axeLocked = PlayerPrefs.GetInt("AxeLocked");
        robberLocked = PlayerPrefs.GetInt("RobberLocked");
        spartaLocked = PlayerPrefs.GetInt("SpartaLocked");
        laserswordLocked = PlayerPrefs.GetInt("LaserswordLocked");
        firewizardLocked = PlayerPrefs.GetInt("FirewizardLocked");
        poisonwizardLocked = PlayerPrefs.GetInt("PoisonwizardLocked");
        electricwizardLocked = PlayerPrefs.GetInt("ElectricwizardLocked");
        samuraiLocked = PlayerPrefs.GetInt("SamuraiLocked");
        grenadeLocked = PlayerPrefs.GetInt("GrenadeLocked");
        girlstudentLocked = PlayerPrefs.GetInt("GirlstudentLocked");
        constructorLocked = PlayerPrefs.GetInt("ConstructorLocked");
        viking2Locked = PlayerPrefs.GetInt("Viking2Locked");
        nurseLocked = PlayerPrefs.GetInt("NurseLocked");
        teacherLocked = PlayerPrefs.GetInt("TeacherLocked");
        artistLocked = PlayerPrefs.GetInt("ArtistLocked");
        baseballBallLocked = PlayerPrefs.GetInt("BaseballBallLocked");
        basketballLocked = PlayerPrefs.GetInt("BasketballLocked");
        demonLocked = PlayerPrefs.GetInt("DemonLocke d");
        englandsoldierLocked = PlayerPrefs.GetInt("EnglandsoldierLocked");
        girlninjaLocked = PlayerPrefs.GetInt("GirlninjaLocked");
        indianLocked = PlayerPrefs.GetInt("IndianLocked");
        pirateLocked = PlayerPrefs.GetInt("PirateLocked");
        piratecaptainLocked = PlayerPrefs.GetInt("PiratecaptainLocked");
        policeLocked = PlayerPrefs.GetInt("PoliceLocked");
        rockerLocked = PlayerPrefs.GetInt("RockerLocked");
        skiLocked = PlayerPrefs.GetInt("SkiLocked");
        bazookaLocked = PlayerPrefs.GetInt("BazookaLocked");
        boneLocked = PlayerPrefs.GetInt("BoneLocked");
        laserLocked = PlayerPrefs.GetInt("LaserLocked");
        lasergunLocked = PlayerPrefs.GetInt("LasergunLocked");
        minigunLocked = PlayerPrefs.GetInt("MinigunLocked");
        gangsterbossLocked = PlayerPrefs.GetInt("GangsterbossLocked");
        vampireLocked = PlayerPrefs.GetInt("VampireLocked");

    }

    void Update()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
        tokenAmount = PlayerPrefs.GetInt("TokenAmount");
        goldAmountText.text = goldAmount.ToString();
        tokenAmountText.text = tokenAmount.ToString();

        if (goldAmount >= 2000)
        {
            CharacterButton.interactable = true;
        }
        else
        {
            CharacterButton.interactable = false;
        }

        if (goldAmount >= 100)
        {
            tokenButton.interactable = true;
        }
        else
        {
            tokenButton.interactable = false;
        }

        if (goldAmount >= 1000)
        {
            tokenButton2.interactable = true;
        }
        else
        {
            tokenButton2.interactable = false;
        }

    }

    public void boxHealthDecrease()
    {
        boxHealth -= boxDamageAmount;

        if (boxHealth > 6)
        {
            splash.sprite = Box1;
        }
        else if (boxHealth > 4)
        {
            splash.sprite = Box2;
        }
        else if (boxHealth > 2)
        {
            splash.sprite = Box3;
        }
        else if (boxHealth > 0)
        {
            splash.sprite = Box4;
        }
        else
        {
            RandomCharacter();
            splash.sprite = Box5;
        }

    }

    public void RandomCharacter()
    {
        randomintCharacter = Random.Range(0, 100);

        if (randomintCharacter >= 56)
        {
            randomNumber = Random.Range(0, 11);
        }
        else if (randomintCharacter < 56 && randomintCharacter >= 24)
        {
            randomNumber = Random.Range(11, 22);
        }
        else if (randomintCharacter < 24 && randomintCharacter >= 2)
        {
            randomNumber = Random.Range(22, 35);
        }
        else
        {
            randomNumber = Random.Range(35, 41);
        }

        unlockedPanel.SetActive(true);

        if (randomNumber == 11)
        {
            characterSplash.sprite = sniperSplash;
            characterName.text = "Sniper";

            if (PlayerPrefs.GetInt("SniperLocked") == 1)
            {
                PlayerPrefs.SetInt("SniperLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("SniperLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 22)
        {
            characterSplash.sprite = cowboySplash;
            characterName.text = "Cowboy";

            if (PlayerPrefs.GetInt("ShotgunLocked") == 1)
            {
                PlayerPrefs.SetInt("ShotgunLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("ShotgunLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 23)
        {
            characterSplash.sprite = soldierSplash;
            characterName.text = "Soldier";

            if (PlayerPrefs.GetInt("RifleLocked") == 1)
            {
                PlayerPrefs.SetInt("RifleLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("RifleLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 24)
        {
            characterSplash.sprite = gangsterSplash;
            characterName.text = "Gangster";

            if (PlayerPrefs.GetInt("TommygunLocked") == 1)
            {
                PlayerPrefs.SetInt("TommygunLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("TommygunLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);

            }
        }

        else if (randomNumber == 12)
        {
            characterSplash.sprite = fisherSplash;
            characterName.text = "Fisher";

            if (PlayerPrefs.GetInt("FisherLocked") == 1)
            {
                PlayerPrefs.SetInt("FisherLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("FisherLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);

            }
        }

        else if (randomNumber == 0)
        {
            characterSplash.sprite = chefSplash;
            characterName.text = "Chef";

            if (PlayerPrefs.GetInt("ChefLocked") == 1)
            {
                PlayerPrefs.SetInt("ChefLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("ChefLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);

            }
        }

        else if (randomNumber == 1)
        {
            characterSplash.sprite = mineSplash;
            characterName.text = "Mine Worker";

            if (PlayerPrefs.GetInt("MineLocked") == 1)
            {
                PlayerPrefs.SetInt("MineLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("MineLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);

            }
        }

        else if (randomNumber == 13)
        {
            characterSplash.sprite = ninjaSplash;
            characterName.text = "Ninja";

            if (PlayerPrefs.GetInt("NinjaLocked") == 1)
            {
                PlayerPrefs.SetInt("NinjaLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("NinjaLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);

            }
        }

        else if (randomNumber == 14)
        {
            characterSplash.sprite = axeSplash;
            characterName.text = "Wood Cutter";

            if (PlayerPrefs.GetInt("AxeLocked") == 1)
            {
                PlayerPrefs.SetInt("AxeLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("AxeLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);

            }
        }

        else if (randomNumber == 2)
        {
            characterSplash.sprite = robberSplash;
            characterName.text = "Robber";

            if (PlayerPrefs.GetInt("RobberLocked") == 1)
            {
                PlayerPrefs.SetInt("RobberLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("RobberLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 15)
        {
            characterSplash.sprite = spartaSplash;
            characterName.text = "Sparta Man";

            if (PlayerPrefs.GetInt("SpartaLocked") == 1)
            {
                PlayerPrefs.SetInt("SpartaLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("SpartaLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 16)
        {
            characterSplash.sprite = laserswordSplash;
            characterName.text = "Space Warrior";

            if (PlayerPrefs.GetInt("LaserswordLocked") == 1)
            {
                PlayerPrefs.SetInt("LaserswordLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("LaserswordLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 25)
        {
            characterSplash.sprite = firewizardSplash;
            characterName.text = "Fire Wizard";

            if (PlayerPrefs.GetInt("FirewizardLocked") == 1)
            {
                PlayerPrefs.SetInt("FirewizardLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("FirewizardLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 26)
        {
            characterSplash.sprite = poisonwizardSplash;
            characterName.text = "Poison Wizard";

            if (PlayerPrefs.GetInt("PoisonwizardLocked") == 1)
            {
                PlayerPrefs.SetInt("PoisonwizardLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("PoisonwizardLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 27)
        {
            characterSplash.sprite = electricwizardSplash;
            characterName.text = "Electric Wizard";

            if (PlayerPrefs.GetInt("ElectricwizardLocked") == 1)
            {
                PlayerPrefs.SetInt("ElectricwizardLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("ElectricwizardLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 17)
        {
            characterSplash.sprite = samuraiSplash;
            characterName.text = "Samurai";

            if (PlayerPrefs.GetInt("SamuraiLocked") == 1)
            {
                PlayerPrefs.SetInt("SamuraiLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("SamuraiLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 28)
        {
            characterSplash.sprite = grenadeSplash;
            characterName.text = "Grenade Soldier";

            if (PlayerPrefs.GetInt("GrenadeLocked") == 1)
            {
                PlayerPrefs.SetInt("GrenadeLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("GrenadeLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 18)
        {
            characterSplash.sprite = girlstudentSplash;
            characterName.text = "Girl Student";

            if (PlayerPrefs.GetInt("GirlstudentLocked") == 1)
            {
                PlayerPrefs.SetInt("GirlstudentLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("GirlstudentLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 29)
        {
            characterSplash.sprite = constructorSplash;
            characterName.text = "Constructor";

            if (PlayerPrefs.GetInt("ConstructorLocked") == 1)
            {
                PlayerPrefs.SetInt("ConstructorLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("ConstructorLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 3)
        {
            characterSplash.sprite = viking2Splash;
            characterName.text = "Viking";

            if (PlayerPrefs.GetInt("Viking2Locked") == 1)
            {
                PlayerPrefs.SetInt("Viking2Locked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("Viking2Locked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 4)
        {
            characterSplash.sprite = nurseSplash;
            characterName.text = "Nurse";

            if (PlayerPrefs.GetInt("NurseLocked") == 1)
            {
                PlayerPrefs.SetInt("NurseLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("NurseLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 5)
        {
            characterSplash.sprite = teacherSplash;
            characterName.text = "Teacher";

            if (PlayerPrefs.GetInt("TeacherLocked") == 1)
            {
                PlayerPrefs.SetInt("TeacherLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("TeacherLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 6)
        {
            characterSplash.sprite = artistSplash;
            characterName.text = "Artist";

            if (PlayerPrefs.GetInt("ArtistLocked") == 1)
            {
                PlayerPrefs.SetInt("ArtistLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("ArtistLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 7)
        {
            characterSplash.sprite = baseballBallSplash;
            characterName.text = "Baseball Pitcher";

            if (PlayerPrefs.GetInt("BaseballBallLocked") == 1)
            {
                PlayerPrefs.SetInt("BaseballBallLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("BaseballBallLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 8)
        {
            characterSplash.sprite = basketballSplash;
            characterName.text = "Basketball Player";

            if (PlayerPrefs.GetInt("BasketballLocked") == 1)
            {
                PlayerPrefs.SetInt("BasketballLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("BasketballLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 19)
        {
            characterSplash.sprite = demonSplash;
            characterName.text = "Demon";

            if (PlayerPrefs.GetInt("DemonLocked") == 1)
            {
                PlayerPrefs.SetInt("DemonLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("DemonLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 30)
        {
            characterSplash.sprite = englandsoldierSplash;
            characterName.text = "England Soldier";

            if (PlayerPrefs.GetInt("EnglandsoldierLocked") == 1)
            {
                PlayerPrefs.SetInt("EnglandsoldierLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("EnglandsoldierLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 31)
        {
            characterSplash.sprite = girlninjaSplash;
            characterName.text = "Ninja Girl";

            if (PlayerPrefs.GetInt("girlninjaLocked") == 1)
            {
                PlayerPrefs.SetInt("girlninjaLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("girlninjaLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 20)
        {
            characterSplash.sprite = indianSplash;
            characterName.text = "Native Indian";

            if (PlayerPrefs.GetInt("IndianLocked") == 1)
            {
                PlayerPrefs.SetInt("IndianLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("IndianLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 21)
        {
            characterSplash.sprite = pirateSplash;
            characterName.text = "Pirate";

            if (PlayerPrefs.GetInt("PirateLocked") == 1)
            {
                PlayerPrefs.SetInt("PirateLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("PirateLocked", 1);
                newOrNotText.text = "Rare New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 32)
        {
            characterSplash.sprite = piratecaptainSplash;
            characterName.text = "Pirate Captain";

            if (PlayerPrefs.GetInt("PiratecaptainLocked") == 1)
            {
                PlayerPrefs.SetInt("PiratecaptainLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("PiratecaptainLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 9)
        {
            characterSplash.sprite = policeSplash;
            characterName.text = "Police";

            if (PlayerPrefs.GetInt("PoliceLocked") == 1)
            {
                PlayerPrefs.SetInt("PoliceLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("PoliceLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 33)
        {
            characterSplash.sprite = rockerSplash;
            characterName.text = "Rocker";

            if (PlayerPrefs.GetInt("RockerLocked") == 1)
            {
                PlayerPrefs.SetInt("RockerLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("RockerLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 10)
        {
            characterSplash.sprite = skiSplash;
            characterName.text = "Ski";

            if (PlayerPrefs.GetInt("SkiLocked") == 1)
            {
                PlayerPrefs.SetInt("SkiLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("SkiLocked", 1);
                newOrNotText.text = "Common New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 35)
        {
            characterSplash.sprite = bazookaSplash;
            characterName.text = "Bazooka Soldier";

            if (PlayerPrefs.GetInt("BazookaLocked") == 1)
            {
                PlayerPrefs.SetInt("BazookaLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("BazookaLocked", 1);
                newOrNotText.text = "Legend New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 36)
        {
            characterSplash.sprite = boneSplash;
            characterName.text = "Man of Bone";

            if (PlayerPrefs.GetInt("BoneLocked") == 1)
            {
                PlayerPrefs.SetInt("BoneLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("BoneLocked", 1);
                newOrNotText.text = "Legend New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 34)
        {
            characterSplash.sprite = laserSplash;
            characterName.text = "Space Soldier";

            if (PlayerPrefs.GetInt("LaserLocked") == 1)
            {
                PlayerPrefs.SetInt("LaserLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("LaserLocked", 1);
                newOrNotText.text = "Epic New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 37)
        {
            characterSplash.sprite = lasergunSplash;
            characterName.text = "Space Captain";

            if (PlayerPrefs.GetInt("LasergunLocked") == 1)
            {
                PlayerPrefs.SetInt("LasergunLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("LasergunLocked", 1);
                newOrNotText.text = "Legend New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 38)
        {
            characterSplash.sprite = minigunSplash;
            characterName.text = "Crazy Shooter";

            if (PlayerPrefs.GetInt("MinigunLocked") == 1)
            {
                PlayerPrefs.SetInt("MinigunLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("MinigunLocked", 1);
                newOrNotText.text = "Legend New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 39)
        {
            characterSplash.sprite = gangsterbossSplash;
            characterName.text = "Gangster Boss";

            if (PlayerPrefs.GetInt("GangsterbossLocked") == 1)
            {
                PlayerPrefs.SetInt("GangsterbossLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("GangsterbossLocked", 1);
                newOrNotText.text = "Legend New Character!";
                goldreturn.SetActive(false);
            }
        }

        else if (randomNumber == 40)
        {
            characterSplash.sprite = vampireSplash;
            characterName.text = "Vampire";

            if (PlayerPrefs.GetInt("VampireLocked") == 1)
            {
                PlayerPrefs.SetInt("VampireLocked", 1);
                newOrNotText.text = "Already Have It...";
                goldreturn.SetActive(true);
                goldAmount += 1000;
                PlayerPrefs.SetInt("GoldAmount", goldAmount);
                tokenAmount += 5;
                PlayerPrefs.SetInt("TokenAmount", tokenAmount);
            }

            else
            {
                PlayerPrefs.SetInt("VampireLocked", 1);
                newOrNotText.text = "Legend New Character!";
                goldreturn.SetActive(false);
            }
        }

        SoundManagerScript.PlaySound("buttonclick");
        goldAmount -= 2000;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
    }



    public void GoldtoToken()
    {
        randomNumber = Random.Range(0, 100);
        if (randomNumber >= 50)
        {
            tokenPlus = 1;
            tokenPlusText.text = tokenPlus.ToString();
            tokenPlusImage.sprite = OnetokenSplash;
        }
        else if (randomNumber < 50 && randomNumber >= 15)
        {
            tokenPlus = 2;
            tokenPlusText.text = tokenPlus.ToString();
            tokenPlusImage.sprite = TwotokenSplash;
        }
        else
        {
            tokenPlus = 3;
            tokenPlusText.text = tokenPlus.ToString();
            tokenPlusImage.sprite = ThreetokenSplash;
        }

        TokenPanel.SetActive(true);

        SoundManagerScript.PlaySound("buttonclick");

        goldAmount -= 100;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);

        tokenAmount += tokenPlus;
        PlayerPrefs.SetInt("TokenAmount", tokenAmount);
    }

    public void GoldtoTokenALot()
    {

        randomNumberALot = Random.Range(10, 31);
        SoundManagerScript.PlaySound("buttonclick");

        tokenPlusText.text = randomNumberALot.ToString();
        tokenPlusImage.sprite = LotsoftokenSplash;

        TokenPanel.SetActive(true);

        goldAmount -= 1000;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);

        tokenAmount += randomNumberALot;
        PlayerPrefs.SetInt("TokenAmount", tokenAmount);
    }


    public void closeUnlockedPanel()
    {
        unlockedPanel.SetActive(false);
    }

    public void closetokenPanel()
    {
        TokenPanel.SetActive(false);
    }

    public void openInformPanel()
    {
        InformPanel.SetActive(true);
    }

    public void closeInformPanel()
    {
        InformPanel.SetActive(false);
    }

    public void openCharacterPopUp()
    {
        characterPopUP.SetActive(true);
    }

    public void closeCharacterPopUp()
    {
        boxHealth = 8;
        splash.sprite = Box1;
        characterPopUP.SetActive(false);
    }
    

    public void toZero()
    {
        goldAmount = 0;
        PlayerPrefs.SetInt("GoldAmount", goldAmount);
        tokenAmount = 0;
        PlayerPrefs.SetInt("TokenAmount", tokenAmount);

        PlayerPrefs.SetInt("SniperLocked", 0);
        PlayerPrefs.SetInt("ShotgunLocked", 0);
        PlayerPrefs.SetInt("RifleLocked", 0);
        PlayerPrefs.SetInt("MinigunLocked", 0);
        PlayerPrefs.SetInt("TommygunLocked", 0);
        PlayerPrefs.SetInt("FisherLocked", 0);
        PlayerPrefs.SetInt("LaserLocked", 0);
        PlayerPrefs.SetInt("ChefLocked", 0);
        PlayerPrefs.SetInt("BaseballLocked", 0);
        PlayerPrefs.SetInt("MineLocked", 0);
        PlayerPrefs.SetInt("FarmerLocked", 0);
        PlayerPrefs.SetInt("NinjaLocked", 0);
        PlayerPrefs.SetInt("AxeLocked", 0);
        PlayerPrefs.SetInt("RobberLocked", 0);
        PlayerPrefs.SetInt("SpartaLocked", 0);
        PlayerPrefs.SetInt("BoneLocked", 0);
        PlayerPrefs.SetInt("LasergunLocked", 0);
        PlayerPrefs.SetInt("LaserswordLocked", 0);
        PlayerPrefs.SetInt("FirewizardLocked", 0);
        PlayerPrefs.SetInt("PoisonwizardLocked", 0);
        PlayerPrefs.SetInt("WindwizardLocked", 0);
        PlayerPrefs.SetInt("ElectricwizardLocked", 0);
        PlayerPrefs.SetInt("SamuraiLocked", 0);
        PlayerPrefs.SetInt("GrenadeLocked", 0);
        PlayerPrefs.SetInt("BazookaLocked", 0);
        PlayerPrefs.SetInt("GirlstudentLocked", 0);
        PlayerPrefs.SetInt("ConstructorLocked", 0);
        PlayerPrefs.SetInt("Viking1Locked", 0);
        PlayerPrefs.SetInt("Viking2Locked", 0);
        PlayerPrefs.SetInt("NurseLocked", 0);
        PlayerPrefs.SetInt("TeacherLocked", 0);
        PlayerPrefs.SetInt("TreeLocked", 0);
        PlayerPrefs.SetInt("RockmanLocked", 0);
        PlayerPrefs.SetInt("ArtistLocked", 0);
        PlayerPrefs.SetInt("BaseballBallLocked", 0);
        PlayerPrefs.SetInt("BasketballLocked", 0);
        PlayerPrefs.SetInt("DemonLocked", 0);
        PlayerPrefs.SetInt("EnglandsoldierLocked", 0);
        PlayerPrefs.SetInt("GangsterbossLocked", 0);
        PlayerPrefs.SetInt("GirlninjaLocked", 0);
        PlayerPrefs.SetInt("HealthtrainerLocked", 0);
        PlayerPrefs.SetInt("IndianLocked", 0);
        PlayerPrefs.SetInt("PirateLocked", 0);
        PlayerPrefs.SetInt("PiratecaptainLocked", 0);
        PlayerPrefs.SetInt("PoliceLocked", 0);
        PlayerPrefs.SetInt("RockerLocked", 0);
        PlayerPrefs.SetInt("SkiLocked", 0);
        PlayerPrefs.SetInt("VampireLocked", 0);
        PlayerPrefs.SetInt("WrenchLocked", 0);

        PlayerPrefs.SetInt("Pistolattacklevel", 0);
        PlayerPrefs.SetInt("Pistolhealthlevel", 0);
        PlayerPrefs.SetInt("Pistolspeedlevel", 0);

        PlayerPrefs.SetInt("Sniperattacklevel", 0);
        PlayerPrefs.SetInt("Sniperhealthlevel", 0);
        PlayerPrefs.SetInt("Sniperspeedlevel", 0);

        PlayerPrefs.SetInt("Shotgunattacklevel", 0);
        PlayerPrefs.SetInt("Shotgunhealthlevel", 0);
        PlayerPrefs.SetInt("Shotgunspeedlevel", 0);

        PlayerPrefs.SetInt("Rifleattacklevel", 0);
        PlayerPrefs.SetInt("Riflehealthlevel", 0);
        PlayerPrefs.SetInt("Riflespeedlevel", 0);

        PlayerPrefs.SetInt("Minigunattacklevel", 0);
        PlayerPrefs.SetInt("Minigunhealthlevel", 0);
        PlayerPrefs.SetInt("Minigunspeedlevel", 0);

        PlayerPrefs.SetInt("Tommyattacklevel", 0);
        PlayerPrefs.SetInt("Tommyhealthlevel", 0);
        PlayerPrefs.SetInt("Tommyspeedlevel", 0);

        PlayerPrefs.SetInt("Fisherattacklevel", 0);
        PlayerPrefs.SetInt("Fisherhealthlevel", 0);
        PlayerPrefs.SetInt("Fisherspeedlevel", 0);

        PlayerPrefs.SetInt("Laserattacklevel", 0);
        PlayerPrefs.SetInt("Laserhealthlevel", 0);
        PlayerPrefs.SetInt("Laserspeedlevel", 0);

        PlayerPrefs.SetInt("Chefattacklevel", 0);
        PlayerPrefs.SetInt("Chefhealthlevel", 0);
        PlayerPrefs.SetInt("Chefspeedlevel", 0);

        PlayerPrefs.SetInt("Baseballattacklevel", 0);
        PlayerPrefs.SetInt("Baseballhealthlevel", 0);
        PlayerPrefs.SetInt("Baseballspeedlevel", 0);

        PlayerPrefs.SetInt("Mineattacklevel", 0);
        PlayerPrefs.SetInt("Minehealthlevel", 0);
        PlayerPrefs.SetInt("Minespeedlevel", 0);

        PlayerPrefs.SetInt("Farmerattacklevel", 0);
        PlayerPrefs.SetInt("Farmerhealthlevel", 0);
        PlayerPrefs.SetInt("Farmerspeedlevel", 0);

        PlayerPrefs.SetInt("Ninjaattacklevel", 0);
        PlayerPrefs.SetInt("Ninjahealthlevel", 0);
        PlayerPrefs.SetInt("Ninjaspeedlevel", 0);

        PlayerPrefs.SetInt("Axeattacklevel", 0);
        PlayerPrefs.SetInt("Axehealthlevel", 0);
        PlayerPrefs.SetInt("Axespeedlevel", 0);

        PlayerPrefs.SetInt("Robberattacklevel", 0);
        PlayerPrefs.SetInt("Robberhealthlevel", 0);
        PlayerPrefs.SetInt("Robberspeedlevel", 0);

        PlayerPrefs.SetInt("Spartaattacklevel", 0);
        PlayerPrefs.SetInt("Spartahealthlevel", 0);
        PlayerPrefs.SetInt("Spartaspeedlevel", 0);

        PlayerPrefs.SetInt("Boneattacklevel", 0);
        PlayerPrefs.SetInt("Bonehealthlevel", 0);
        PlayerPrefs.SetInt("Bonespeedlevel", 0);

        PlayerPrefs.SetInt("Lasergunattacklevel", 0);
        PlayerPrefs.SetInt("Lasergunhealthlevel", 0);
        PlayerPrefs.SetInt("Lasergunspeedlevel", 0);

        PlayerPrefs.SetInt("Laserswordattacklevel", 0);
        PlayerPrefs.SetInt("Laserswordhealthlevel", 0);
        PlayerPrefs.SetInt("Laserswordspeedlevel", 0);

        PlayerPrefs.SetInt("Firewizardattacklevel", 0);
        PlayerPrefs.SetInt("Firewizardhealthlevel", 0);
        PlayerPrefs.SetInt("Firewizardspeedlevel", 0);

        PlayerPrefs.SetInt("Poisonwizardattacklevel", 0);
        PlayerPrefs.SetInt("Poisonwizardhealthlevel", 0);
        PlayerPrefs.SetInt("Poisonwizardspeedlevel", 0);

        PlayerPrefs.SetInt("Windwizardattacklevel", 0);
        PlayerPrefs.SetInt("Windwizardhealthlevel", 0);
        PlayerPrefs.SetInt("Windwizardspeedlevel", 0);

        PlayerPrefs.SetInt("Electricwizardattacklevel", 0);
        PlayerPrefs.SetInt("Electricwizardhealthlevel", 0);
        PlayerPrefs.SetInt("Electricwizardspeedlevel", 0);

        PlayerPrefs.SetInt("Samuraiattacklevel", 0);
        PlayerPrefs.SetInt("Samuraihealthlevel", 0);
        PlayerPrefs.SetInt("Samuraispeedlevel", 0);

        PlayerPrefs.SetInt("Grenadeattacklevel", 0);
        PlayerPrefs.SetInt("Grenadehealthlevel", 0);
        PlayerPrefs.SetInt("Grenadespeedlevel", 0);

        PlayerPrefs.SetInt("Bazookaattacklevel", 0);
        PlayerPrefs.SetInt("Bazookahealthlevel", 0);
        PlayerPrefs.SetInt("Bazookaspeedlevel", 0);

        PlayerPrefs.SetInt("Girlstudentattacklevel", 0);
        PlayerPrefs.SetInt("Girlstudenthealthlevel", 0);
        PlayerPrefs.SetInt("Girlstudentspeedlevel", 0);

        PlayerPrefs.SetInt("Constructorattacklevel", 0);
        PlayerPrefs.SetInt("Constructorhealthlevel", 0);
        PlayerPrefs.SetInt("Constructorspeedlevel", 0);

        PlayerPrefs.SetInt("Viking1attacklevel", 0);
        PlayerPrefs.SetInt("Viking1healthlevel", 0);
        PlayerPrefs.SetInt("Viking1speedlevel", 0);

        PlayerPrefs.SetInt("Viking2attacklevel", 0);
        PlayerPrefs.SetInt("Viking2healthlevel", 0);
        PlayerPrefs.SetInt("Viking2speedlevel", 0);

        PlayerPrefs.SetInt("Nurseattacklevel", 0);
        PlayerPrefs.SetInt("Nursehealthlevel", 0);
        PlayerPrefs.SetInt("Nursespeedlevel", 0);

        PlayerPrefs.SetInt("Teacherattacklevel", 0);
        PlayerPrefs.SetInt("Teacherhealthlevel", 0);
        PlayerPrefs.SetInt("Teacherspeedlevel", 0);

        PlayerPrefs.SetInt("Treeattacklevel", 0);
        PlayerPrefs.SetInt("Treehealthlevel", 0);
        PlayerPrefs.SetInt("Treespeedlevel", 0);

        PlayerPrefs.SetInt("Rockmanattacklevel", 0);
        PlayerPrefs.SetInt("Rockmanhealthlevel", 0);
        PlayerPrefs.SetInt("Rockmanspeedlevel", 0);

        PlayerPrefs.SetInt("Artistattacklevel", 0);
        PlayerPrefs.SetInt("Artisthealthlevel", 0);
        PlayerPrefs.SetInt("Artistspeedlevel", 0);

        PlayerPrefs.SetInt("BaseballBallattacklevel", 0);
        PlayerPrefs.SetInt("BaseballBallhealthlevel", 0);
        PlayerPrefs.SetInt("BaseballBallspeedlevel", 0);

        PlayerPrefs.SetInt("Basketballattacklevel", 0);
        PlayerPrefs.SetInt("Basketballhealthlevel", 0);
        PlayerPrefs.SetInt("Basketballspeedlevel", 0);

        PlayerPrefs.SetInt("Demonattacklevel", 0);
        PlayerPrefs.SetInt("Demonhealthlevel", 0);
        PlayerPrefs.SetInt("Demonspeedlevel", 0);

        PlayerPrefs.SetInt("Englandsoldierattacklevel", 0);
        PlayerPrefs.SetInt("Englandsoldierhealthlevel", 0);
        PlayerPrefs.SetInt("Englandsoldierspeedlevel", 0);

        PlayerPrefs.SetInt("Gangsterbossattacklevel", 0);
        PlayerPrefs.SetInt("Gangsterbosshealthlevel", 0);
        PlayerPrefs.SetInt("Gangsterbossspeedlevel", 0);

        PlayerPrefs.SetInt("Girlninjaattacklevel", 0);
        PlayerPrefs.SetInt("Girlninjahealthlevel", 0);
        PlayerPrefs.SetInt("Girlninjaspeedlevel", 0);

        PlayerPrefs.SetInt("Healthtrainerattacklevel", 0);
        PlayerPrefs.SetInt("Healthtrainerhealthlevel", 0);
        PlayerPrefs.SetInt("Healthtrainerspeedlevel", 0);

        PlayerPrefs.SetInt("Indianattacklevel", 0);
        PlayerPrefs.SetInt("Indianhealthlevel", 0);
        PlayerPrefs.SetInt("Indianspeedlevel", 0);

        PlayerPrefs.SetInt("Pirateattacklevel", 0);
        PlayerPrefs.SetInt("Piratehealthlevel", 0);
        PlayerPrefs.SetInt("Piratespeedlevel", 0);

        PlayerPrefs.SetInt("Piratecaptainattacklevel", 0);
        PlayerPrefs.SetInt("Piratecaptainhealthlevel", 0);
        PlayerPrefs.SetInt("Piratecaptainspeedlevel", 0);

        PlayerPrefs.SetInt("Policeattacklevel", 0);
        PlayerPrefs.SetInt("Policehealthlevel", 0);
        PlayerPrefs.SetInt("Policespeedlevel", 0);

        PlayerPrefs.SetInt("Rockerattacklevel", 0);
        PlayerPrefs.SetInt("Rockerhealthlevel", 0);
        PlayerPrefs.SetInt("Rockerspeedlevel", 0);

        PlayerPrefs.SetInt("Skiattacklevel", 0);
        PlayerPrefs.SetInt("Skihealthlevel", 0);
        PlayerPrefs.SetInt("Skispeedlevel", 0);

        PlayerPrefs.SetInt("Vampireattacklevel", 0);
        PlayerPrefs.SetInt("Vampirehealthlevel", 0);
        PlayerPrefs.SetInt("Vampirespeedlevel", 0);

        PlayerPrefs.SetInt("Wrenchattacklevel", 0);
        PlayerPrefs.SetInt("Wrenchhealthlevel", 0);
        PlayerPrefs.SetInt("Wrenchspeedlevel", 0);

        PlayerPrefs.SetInt("HighScore", 0);

        PlayerPrefs.SetInt("HealthPotionLevel", 0);
        PlayerPrefs.SetInt("SpeedPotionLevel", 0);
        PlayerPrefs.SetInt("AttackPotionLevel", 0);
    }
}
