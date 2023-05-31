using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using DentedPixel;

public class GameManagerScript : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject PauseConfirm;


    public static bool gameEnded = false;

    public static int goldAmount;
    public TextMeshProUGUI goldText;

    public GameObject gameover;

    

    void Start()
    {
        goldAmount = PlayerPrefs.GetInt("GoldAmount");
    }

    void Update()
    {
        goldText.text = goldAmount.ToString();
        PlayerPrefs.SetInt("GoldAmount", goldAmount);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        EndGame();
    }

    public void EndGame()
    {
        if (gameEnded == true)
        {
            PauseConfirm.SetActive(false);
            gameover.SetActive(true);
            Time.timeScale = 0f;

            Axe_Script.axeHealthAmount = Axe_Script.tempaxeHealthAmount;
            Axe_Script.jumpForce = Axe_Script.tempjumpForce;
            Axe_Script.speed = Axe_Script.tempspeed;
            Axe_Attack.axedamage = Axe_Attack.tempaxedamage;

            Bazooka_Script.bazookaHealthAmount = Bazooka_Script.tempbazookaHealthAmount;
            Bazooka_Script.jumpForce = Bazooka_Script.tempjumpForce;
            Bazooka_Script.speed = Bazooka_Script.tempspeed;
            Bazooka_Bullet.bazookadamage = Bazooka_Bullet.tempbazookadamage;

            Bone_Script.boneHealthAmount = Bone_Script.tempboneHealthAmount;
            Bone_Script.jumpForce = Bone_Script.tempjumpForce;
            Bone_Script.speed = Bone_Script.tempspeed;
            Bone_Bullet.bonedamage = Bone_Bullet.tempbonedamage;

            Chef_Script.chefHealthAmount = Chef_Script.tempchefHealthAmount;
            Chef_Script.jumpForce = Chef_Script.tempjumpForce;
            Chef_Script.speed = Chef_Script.tempspeed;
            Chef_Bullet.chefdamage = Chef_Bullet.tempchefdamage;

            Constructor_Script.constructorHealthAmount = Constructor_Script.tempconstructorHealthAmount;
            Constructor_Script.jumpForce = Constructor_Script.tempjumpForce;
            Constructor_Script.speed = Constructor_Script.tempspeed;
            Constructor_Attack.constructordamage = Constructor_Attack.tempconstructordamage;

            ElectricWizard_Script.electricwizardHealthAmount = ElectricWizard_Script.tempelectricwizardHealthAmount;
            ElectricWizard_Script.jumpForce = ElectricWizard_Script.tempjumpForce;
            ElectricWizard_Script.speed = ElectricWizard_Script.tempspeed;
            ElectricWizard_Attack.electricwizarddamage = ElectricWizard_Attack.tempelectricwizarddamage;

            GirlStudent_Script.girlstudentHealthAmount = GirlStudent_Script.tempgirlstudentHealthAmount;
            GirlStudent_Script.jumpForce = GirlStudent_Script.tempjumpForce;
            GirlStudent_Script.speed = GirlStudent_Script.tempspeed;
            GirlStudent_Bullet.girlstudentdamage = GirlStudent_Bullet.tempgirlstudentdamage;

            Firewizard_Script.firewizardHealthAmount = Firewizard_Script.tempfirewizardHealthAmount;
            Firewizard_Script.jumpForce = Firewizard_Script.tempjumpForce;
            Firewizard_Script.speed = Firewizard_Script.tempspeed;
            Firewizard_Attack.firewizarddamage = Firewizard_Attack.tempfirewizarddamage;

            Grenademan_Script.grenadeHealthAmount = Grenademan_Script.tempgrenadeHealthAmount;
            Grenademan_Script.jumpForce = Grenademan_Script.tempjumpForce;
            Grenademan_Script.speed = Grenademan_Script.tempspeed;
            Grenade_Attack.grenadedamage = Grenade_Attack.tempgrenadedamage;

            Harpoon_Script.harpoonHealthAmount = Harpoon_Script.tempharpoonHealthAmount;
            Harpoon_Script.jumpForce = Harpoon_Script.tempjumpForce;
            Harpoon_Script.speed = Harpoon_Script.tempspeed;
            Harpoon_Bullet.harpoondamage = Harpoon_Bullet.tempharpoondamage;

            Laser_Script.laserHealthAmount = Laser_Script.templaserHealthAmount;
            Laser_Script.jumpForce = Laser_Script.tempjumpForce;
            Laser_Script.speed = Laser_Script.tempspeed;
            Laser_Bullet.laserdamage = Laser_Bullet.templaserdamage;

            LaserGun_Script.lasergunHealthAmount = LaserGun_Script.templasergunHealthAmount;
            LaserGun_Script.jumpForce = LaserGun_Script.tempjumpForce;
            LaserGun_Script.speed = LaserGun_Script.tempspeed;
            LaserGun_Attack.lasergundamage = LaserGun_Attack.templasergundamage;

            Lasersword_Script.laserswordHealthAmount = Lasersword_Script.templaserswordHealthAmount;
            Lasersword_Script.jumpForce = Lasersword_Script.tempjumpForce;
            Lasersword_Script.speed = Lasersword_Script.tempspeed;
            Lasersword_Attack.lasersworddamage = Lasersword_Attack.templasersworddamage;

            Move2.pistolHealthAmount = Move2.temppistolHealthAmount;
            Move2.jumpForce = Move2.tempjumpForce;
            Move2.speed = Move2.tempspeed;
            Pistol_Bullet.pistoldamage = Pistol_Bullet.temppistoldamage;

            MineWorker_Script.mineHealthAmount = MineWorker_Script.tempmineHealthAmount;
            MineWorker_Script.jumpForce = MineWorker_Script.tempjumpForce;
            MineWorker_Script.speed = MineWorker_Script.tempspeed;
            Mine_Attack.minedamage = Mine_Attack.tempminedamage;

            Minigun_Script.minigunHealthAmount = Minigun_Script.tempminigunHealthAmount;
            Minigun_Script.jumpForce = Minigun_Script.tempjumpForce;
            Minigun_Script.speed = Minigun_Script.tempspeed;
            Minigun_Bullet.minigundamage = Minigun_Bullet.tempminigundamage;

            Ninja_Script.ninjaHealthAmount = Ninja_Script.tempninjaHealthAmount;
            Ninja_Script.jumpForce = Ninja_Script.tempjumpForce;
            Ninja_Script.speed = Ninja_Script.tempspeed;
            Ninja_Bullet.ninjadamage = Ninja_Bullet.tempninjadamage;

            Nurse_Script.nurseHealthAmount = Nurse_Script.tempnurseHealthAmount;
            Nurse_Script.jumpForce = Nurse_Script.tempjumpForce;
            Nurse_Script.speed = Nurse_Script.tempspeed;
            Nurse_Attack.nursedamage = Nurse_Attack.tempnursedamage;

            Samurai_Script.samuraiHealthAmount = Samurai_Script.tempsamuraiHealthAmount;
            Samurai_Script.jumpForce = Samurai_Script.tempjumpForce;
            Samurai_Script.speed = Samurai_Script.tempspeed;
            Samurai_Attack.samuraidamage = Samurai_Attack.tempsamuraidamage;

            Robber_Script.robberHealthAmount = Robber_Script.temprobberHealthAmount;
            Robber_Script.jumpForce = Robber_Script.tempjumpForce;
            Robber_Script.speed = Robber_Script.tempspeed;
            Robber_Attack.robberdamage = Robber_Attack.temprobberdamage;

            Rifle_Script.rifleHealthAmount = Rifle_Script.temprifleHealthAmount;
            Rifle_Script.jumpForce = Rifle_Script.tempjumpForce;
            Rifle_Script.speed = Rifle_Script.tempspeed;
            Rifle_Bullet.rifledamage = Rifle_Bullet.temprifledamage;

            Poisonwizard_Script.poisonwizardHealthAmount = Poisonwizard_Script.temppoisonwizardHealthAmount;
            Poisonwizard_Script.jumpForce = Poisonwizard_Script.tempjumpForce;
            Poisonwizard_Script.speed = Poisonwizard_Script.tempspeed;
            Poisonwizard_Attack.poisonwizarddamage = Poisonwizard_Attack.temppoisonwizarddamage;

            Tommy_Script.tommyHealthAmount = Tommy_Script.temptommyHealthAmount;
            Tommy_Script.jumpForce = Tommy_Script.tempjumpForce;
            Tommy_Script.speed = Tommy_Script.tempspeed;
            Tommy_Bullet.tommydamage = Tommy_Bullet.temptommydamage;

            Teacher_Script.teacherHealthAmount = Teacher_Script.tempteacherHealthAmount;
            Teacher_Script.jumpForce = Teacher_Script.tempjumpForce;
            Teacher_Script.speed = Teacher_Script.tempspeed;
            Teacher_Attack.teacherdamage = Teacher_Attack.tempteacherdamage;

            Sparta_Script.spartaHealthAmount = Sparta_Script.tempspartaHealthAmount;
            Sparta_Script.jumpForce = Sparta_Script.tempjumpForce;
            Sparta_Script.speed = Sparta_Script.tempspeed;
            Sparta_Attack.spartadamage = Sparta_Attack.tempspartadamage;

            Sniper_Script.sniperHealthAmount = Sniper_Script.tempsniperHealthAmount;
            Sniper_Script.jumpForce = Sniper_Script.tempjumpForce;
            Sniper_Script.speed = Sniper_Script.tempspeed;
            Sniper_Bullet.sniperdamage = Sniper_Bullet.tempsniperdamage;

            Shotgun_Script.shotgunHealthAmount = Shotgun_Script.tempshotgunHealthAmount;
            Shotgun_Script.jumpForce = Shotgun_Script.tempjumpForce;
            Shotgun_Script.speed = Shotgun_Script.tempspeed;
            Shotgun_Bullet.shotgundamage = Shotgun_Bullet.tempshotgundamage;

            Viking2_Script.viking2HealthAmount = Viking2_Script.tempviking2HealthAmount;
            Viking2_Script.jumpForce = Viking2_Script.tempjumpForce;
            Viking2_Script.speed = Viking2_Script.tempspeed;
            Viking2_Attack.viking2damage = Viking2_Attack.tempviking2damage;

            Artist_Script.artistHealthAmount = Artist_Script.tempartistHealthAmount;
            Artist_Script.jumpForce = Artist_Script.tempjumpForce;
            Artist_Script.speed = Artist_Script.tempspeed;
            Artist_Attack.artistdamage = Artist_Attack.tempartistdamage;

            BaseballBall_Script.baseballBallHealthAmount = BaseballBall_Script.tempbaseballBallHealthAmount;
            BaseballBall_Script.jumpForce = BaseballBall_Script.tempjumpForce;
            BaseballBall_Script.speed = BaseballBall_Script.tempspeed;
            BaseballBall_Attack.baseballBalldamage = BaseballBall_Attack.tempbaseballBalldamage;

            Basketball_Script.basketballHealthAmount = Basketball_Script.tempbasketballHealthAmount;
            Basketball_Script.jumpForce = Basketball_Script.tempjumpForce;
            Basketball_Script.speed = Basketball_Script.tempspeed;
            Basketball_Attack.basketballdamage = Basketball_Attack.tempbasketballdamage;

            Demon_Script.demonHealthAmount = Demon_Script.tempdemonHealthAmount;
            Demon_Script.jumpForce = Demon_Script.tempjumpForce;
            Demon_Script.speed = Demon_Script.tempspeed;
            Demon_Attack.demondamage = Demon_Attack.tempdemondamage;

            EnglandSoldier_Script.englandsoldierHealthAmount = EnglandSoldier_Script.tempenglandsoldierHealthAmount;
            EnglandSoldier_Script.jumpForce = EnglandSoldier_Script.tempjumpForce;
            EnglandSoldier_Script.speed = EnglandSoldier_Script.tempspeed;
            EnglandSoldier_Attack.englandsoldierdamage = EnglandSoldier_Attack.tempenglandsoldierdamage;

            GangsterBoss_Script.gangsterbossHealthAmount = GangsterBoss_Script.tempgangsterbossHealthAmount;
            GangsterBoss_Script.jumpForce = GangsterBoss_Script.tempjumpForce;
            GangsterBoss_Script.speed = GangsterBoss_Script.tempspeed;
            GangsterBoss_Attack.gangsterbossdamage = GangsterBoss_Attack.tempgangsterbossdamage;

            GirlNinja_Script.girlninjaHealthAmount = GirlNinja_Script.tempgirlninjaHealthAmount;
            GirlNinja_Script.jumpForce = GirlNinja_Script.tempjumpForce;
            GirlNinja_Script.speed = GirlNinja_Script.tempspeed;
            GirlNinja_Attack.girlninjadamage = GirlNinja_Attack.tempgirlninjadamage;

            Indian_Script.indianHealthAmount = Indian_Script.tempindianHealthAmount;
            Indian_Script.jumpForce = Indian_Script.tempjumpForce;
            Indian_Script.speed = Indian_Script.tempspeed;
            Indian_Attack.indiandamage = Indian_Attack.tempindiandamage;

            Pirate_Script.pirateHealthAmount = Pirate_Script.temppirateHealthAmount;
            Pirate_Script.jumpForce = Pirate_Script.tempjumpForce;
            Pirate_Script.speed = Pirate_Script.tempspeed;
            Pirate_Attack.piratedamage = Pirate_Attack.temppiratedamage;

            PirateCaptain_Script.piratecaptainHealthAmount = PirateCaptain_Script.temppiratecaptainHealthAmount;
            PirateCaptain_Script.jumpForce = PirateCaptain_Script.tempjumpForce;
            PirateCaptain_Script.speed = PirateCaptain_Script.tempspeed;
            PirateCaptain_Attack.piratecaptaindamage = PirateCaptain_Attack.temppiratecaptaindamage;

            Police_Script.policeHealthAmount = Police_Script.temppoliceHealthAmount;
            Police_Script.jumpForce = Police_Script.tempjumpForce;
            Police_Script.speed = Police_Script.tempspeed;
            Police_Attack.policedamage = Police_Attack.temppolicedamage;

            Rocker_Script.rockerHealthAmount = Rocker_Script.temprockerHealthAmount;
            Rocker_Script.jumpForce = Rocker_Script.tempjumpForce;
            Rocker_Script.speed = Rocker_Script.tempspeed;
            Rocker_Attack.rockerdamage = Rocker_Attack.temprockerdamage;

            Ski_Script.skiHealthAmount = Ski_Script.tempskiHealthAmount;
            Ski_Script.jumpForce = Ski_Script.tempjumpForce;
            Ski_Script.speed = Ski_Script.tempspeed;
            Ski_Attack.skidamage = Ski_Attack.tempskidamage;

            Vampire_Script.vampireHealthAmount = Vampire_Script.tempvampireHealthAmount;
            Vampire_Script.jumpForce = Vampire_Script.tempjumpForce;
            Vampire_Script.speed = Vampire_Script.tempspeed;
            Vampire_Attack.vampiredamage = Vampire_Attack.tempvampiredamage;

        }
    }

    public void SetEndGame()
    {
        gameEnded = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void PauseDelete()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }

    public void PauseConfirmMake()
    {
        PauseConfirm.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void PauseConfirmDelete()
    {
        PauseConfirm.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void AdShow()
    {
        AdManagerScript.instance.ShowFullScreenAd();
    }

}
