using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;
using UnityEngine.Events;

public class Health_Player : MonoBehaviour
{
    public static float playerhealthAmount;
    public static float firstplayerhealthAmount;

    public Image whiteFade;

    public GameObject sniper;
    public GameObject basic;
    public GameObject rifle;
    public GameObject shotgun;
    public GameObject minigun;
    public GameObject tommy;
    public GameObject harpoon;
    public GameObject laser;
    public GameObject axe;
    public GameObject bone;
    public GameObject chef;
    public GameObject mine;
    public GameObject ninja;
    public GameObject robber;
    public GameObject sparta;
    public GameObject bazooka;
    public GameObject constructor;
    public GameObject girlstudent;
    public GameObject grenade;
    public GameObject lasergun;
    public GameObject lasersword;
    public GameObject nurse;
    public GameObject samurai;
    public GameObject teacher;
    public GameObject viking2;
    public GameObject firewizard;
    public GameObject electricwizard;
    public GameObject poisonwizard;
    public GameObject artist;
    public GameObject baseballBall;
    public GameObject basketball;
    public GameObject demon;
    public GameObject englandsoldier;
    public GameObject gangsterboss;
    public GameObject girlninja;
    public GameObject indian;
    public GameObject pirate;
    public GameObject piratecaptain;
    public GameObject police;
    public GameObject rocker;
    public GameObject ski;
    public GameObject vampire;

    public TextMesh healthText;

    public bool basiczombie_attack = false;
    public bool flyzombie_attack = false;
    public bool parkourzombie_attack = false;
    public bool sneakyzombie_attack = false;
    public bool canonzombie_attack = false;
    public bool primitivezombie_attack = false;
    public bool shieldzombie_attack = false;
    public bool canonflyzombie_attack = false;
    public bool jetpackzombie_attack = false;

    public float ShakeDuration = 0.3f;
    public float ShakeAmplitude = 7f;
    public float ShakeFrequency = 4f;

    private float ShakeElapsedTime = 0f;

    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineBasicMultiChannelPerlin virtualCameraNoise;

    private string hurtsound;


    // Start is called before the first frame update
    void Start()
    {
        whiteFade.canvasRenderer.SetAlpha(1.0f);

        whiteFade.CrossFadeAlpha(0, 0, false);

        if (VirtualCamera != null)
        {
            virtualCameraNoise = VirtualCamera.GetCinemachineComponent<Cinemachine.CinemachineBasicMultiChannelPerlin>();
        }

        if (basic.activeSelf)
        {
            playerhealthAmount = Move2.pistolHealthAmount + PlayerPrefs.GetInt("Pistolhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (sniper.activeSelf)
        {
            playerhealthAmount = Sniper_Script.sniperHealthAmount + PlayerPrefs.GetInt("Sniperhealthlevel") * 50;
            hurtsound = "girlhit";
        }

        else if (rifle.activeSelf)
        {
            playerhealthAmount = Rifle_Script.rifleHealthAmount + PlayerPrefs.GetInt("Riflehealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (shotgun.activeSelf)
        {
            playerhealthAmount = Shotgun_Script.shotgunHealthAmount + PlayerPrefs.GetInt("Shotgunhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (minigun.activeSelf)
        {
            playerhealthAmount = Minigun_Script.minigunHealthAmount + PlayerPrefs.GetInt("Minigunhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (tommy.activeSelf)
        {
            playerhealthAmount = Tommy_Script.tommyHealthAmount + PlayerPrefs.GetInt("Tommyhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (harpoon.activeSelf)
        {
            playerhealthAmount = Harpoon_Script.harpoonHealthAmount + PlayerPrefs.GetInt("Harpoonhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (laser.activeSelf)
        {
            playerhealthAmount = Laser_Script.laserHealthAmount + PlayerPrefs.GetInt("Laserhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (axe.activeSelf)
        {
            playerhealthAmount = Axe_Script.axeHealthAmount + PlayerPrefs.GetInt("Axehealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (bone.activeSelf)
        {
            playerhealthAmount = Bone_Script.boneHealthAmount + PlayerPrefs.GetInt("Bonehealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (chef.activeSelf)
        {
            playerhealthAmount = Chef_Script.chefHealthAmount + PlayerPrefs.GetInt("Chefhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (mine.activeSelf)
        {
            playerhealthAmount = MineWorker_Script.mineHealthAmount + PlayerPrefs.GetInt("Minehealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (ninja.activeSelf)
        {
            playerhealthAmount = Ninja_Script.ninjaHealthAmount + PlayerPrefs.GetInt("Ninjahealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (robber.activeSelf)
        {
            playerhealthAmount = Robber_Script.robberHealthAmount + PlayerPrefs.GetInt("Robberhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (sparta.activeSelf)
        {
            playerhealthAmount = Sparta_Script.spartaHealthAmount + PlayerPrefs.GetInt("Spartahealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (bazooka.activeSelf)
        {
            playerhealthAmount = Bazooka_Script.bazookaHealthAmount + PlayerPrefs.GetInt("Bazookahealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (constructor.activeSelf)
        {
            playerhealthAmount = Constructor_Script.constructorHealthAmount + PlayerPrefs.GetInt("Constructorhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (girlstudent.activeSelf)
        {
            playerhealthAmount = GirlStudent_Script.girlstudentHealthAmount + PlayerPrefs.GetInt("GirlStudenthealthlevel") * 50;
            hurtsound = "girlhit";
        }

        else if (grenade.activeSelf)
        {
            playerhealthAmount = Grenademan_Script.grenadeHealthAmount + PlayerPrefs.GetInt("Grenadehealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (lasergun.activeSelf)
        {
            playerhealthAmount = LaserGun_Script.lasergunHealthAmount + PlayerPrefs.GetInt("Lasergunhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (lasersword.activeSelf)
        {
            playerhealthAmount = Lasersword_Script.laserswordHealthAmount + PlayerPrefs.GetInt("Laserswordhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (nurse.activeSelf)
        {
            playerhealthAmount = Nurse_Script.nurseHealthAmount + PlayerPrefs.GetInt("Nursehealthlevel") * 50;
            hurtsound = "girlhit";
        }

        else if (samurai.activeSelf)
        {
            playerhealthAmount = Samurai_Script.samuraiHealthAmount + PlayerPrefs.GetInt("Samuraihealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (teacher.activeSelf)
        {
            playerhealthAmount = Teacher_Script.teacherHealthAmount + PlayerPrefs.GetInt("Teacherhealthlevel") * 50;
            hurtsound = "girlhit";
        }

        else if (viking2.activeSelf)
        {
            playerhealthAmount = Viking2_Script.viking2HealthAmount + PlayerPrefs.GetInt("Viking2healthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (firewizard.activeSelf)
        {
            playerhealthAmount = Firewizard_Script.firewizardHealthAmount + PlayerPrefs.GetInt("Firewizardhealthlevel") * 50;
            hurtsound = "girlhit";
        }

        else if (electricwizard.activeSelf)
        {
            playerhealthAmount = ElectricWizard_Script.electricwizardHealthAmount + PlayerPrefs.GetInt("Electricwizardhealthlevel") * 50;
            hurtsound = "girlhit";
        }

        else if (poisonwizard.activeSelf)
        {
            playerhealthAmount = Poisonwizard_Script.poisonwizardHealthAmount + PlayerPrefs.GetInt("Poisonwizardhealthlevel") * 50;
            hurtsound = "girlhit";
        }

        else if (artist.activeSelf)
        {
            playerhealthAmount = Artist_Script.artistHealthAmount + PlayerPrefs.GetInt("Artisthealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (baseballBall.activeSelf)
        {
            playerhealthAmount = BaseballBall_Script.baseballBallHealthAmount + PlayerPrefs.GetInt("BaseballBallhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (basketball.activeSelf)
        {
            playerhealthAmount = Basketball_Script.basketballHealthAmount + PlayerPrefs.GetInt("Basketballhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (demon.activeSelf)
        {
            playerhealthAmount = Demon_Script.demonHealthAmount + PlayerPrefs.GetInt("Demonhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (englandsoldier.activeSelf)
        {
            playerhealthAmount = EnglandSoldier_Script.englandsoldierHealthAmount + PlayerPrefs.GetInt("Englandsoldierhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (gangsterboss.activeSelf)
        {
            playerhealthAmount = GangsterBoss_Script.gangsterbossHealthAmount + PlayerPrefs.GetInt("Gangsterbosshealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (girlninja.activeSelf)
        {
            playerhealthAmount = GirlNinja_Script.girlninjaHealthAmount + PlayerPrefs.GetInt("Girlninjahealthlevel") * 50;
            hurtsound = "girlhit";
        }

        else if (indian.activeSelf)
        {
            playerhealthAmount = Indian_Script.indianHealthAmount + PlayerPrefs.GetInt("Indianhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (pirate.activeSelf)
        {
            playerhealthAmount = Pirate_Script.pirateHealthAmount + PlayerPrefs.GetInt("Piratehealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (piratecaptain.activeSelf)
        {
            playerhealthAmount = PirateCaptain_Script.piratecaptainHealthAmount + PlayerPrefs.GetInt("Piratecaptainhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (police.activeSelf)
        {
            playerhealthAmount = Police_Script.policeHealthAmount + PlayerPrefs.GetInt("Policehealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (rocker.activeSelf)
        {
            playerhealthAmount = Rocker_Script.rockerHealthAmount + PlayerPrefs.GetInt("Rockerhealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (ski.activeSelf)
        {
            playerhealthAmount = Ski_Script.skiHealthAmount + PlayerPrefs.GetInt("Skihealthlevel") * 50;
            hurtsound = "playerhit";
        }

        else if (vampire.activeSelf)
        {
            playerhealthAmount = Vampire_Script.vampireHealthAmount + PlayerPrefs.GetInt("Vampirehealthlevel") * 50;
            hurtsound = "playerhit";
        }


        else
        {
            playerhealthAmount = Move2.pistolHealthAmount + PlayerPrefs.GetInt("Pistolhealthlevel") * 50;
            hurtsound = "playerhit";
        }



        if (basic.activeSelf)
        {
            firstplayerhealthAmount = Move2.pistolHealthAmount + PlayerPrefs.GetInt("Pistolhealthlevel") * 50;
        }

        else if (sniper.activeSelf)
        {
            firstplayerhealthAmount = Sniper_Script.sniperHealthAmount + PlayerPrefs.GetInt("Sniperhealthlevel") * 50;
        }

        else if (rifle.activeSelf)
        {
            firstplayerhealthAmount = Rifle_Script.rifleHealthAmount + PlayerPrefs.GetInt("Riflehealthlevel") * 50;
        }

        else if (shotgun.activeSelf)
        {
            firstplayerhealthAmount = Shotgun_Script.shotgunHealthAmount + PlayerPrefs.GetInt("Shotgunhealthlevel") * 50;
        }

        else if (minigun.activeSelf)
        {
            firstplayerhealthAmount = Minigun_Script.minigunHealthAmount + PlayerPrefs.GetInt("Minigunhealthlevel") * 50;
        }

        else if (tommy.activeSelf)
        {
            firstplayerhealthAmount = Tommy_Script.tommyHealthAmount + PlayerPrefs.GetInt("Tommyhealthlevel") * 50;
        }

        else if (harpoon.activeSelf)
        {
            firstplayerhealthAmount = Harpoon_Script.harpoonHealthAmount + PlayerPrefs.GetInt("Harpoonhealthlevel") * 50;
        }

        else if (laser.activeSelf)
        {
            firstplayerhealthAmount = Laser_Script.laserHealthAmount + PlayerPrefs.GetInt("Laserhealthlevel") * 50;
        }

        else if (axe.activeSelf)
        {
            firstplayerhealthAmount = Axe_Script.axeHealthAmount + PlayerPrefs.GetInt("Axehealthlevel") * 50;
        }

        else if (bone.activeSelf)
        {
            firstplayerhealthAmount = Bone_Script.boneHealthAmount + PlayerPrefs.GetInt("Bonehealthlevel") * 50;
        }

        else if (chef.activeSelf)
        {
            firstplayerhealthAmount = Chef_Script.chefHealthAmount + PlayerPrefs.GetInt("Chefhealthlevel") * 50;
        }

        else if (mine.activeSelf)
        {
            firstplayerhealthAmount = MineWorker_Script.mineHealthAmount + PlayerPrefs.GetInt("Minehealthlevel") * 50;
        }

        else if (ninja.activeSelf)
        {
            firstplayerhealthAmount = Ninja_Script.ninjaHealthAmount + PlayerPrefs.GetInt("Ninjahealthlevel") * 50;
        }

        else if (robber.activeSelf)
        {
            firstplayerhealthAmount = Robber_Script.robberHealthAmount + PlayerPrefs.GetInt("Robberhealthlevel") * 50;
        }

        else if (sparta.activeSelf)
        {
            firstplayerhealthAmount = Sparta_Script.spartaHealthAmount + PlayerPrefs.GetInt("Spartahealthlevel") * 50;
        }

        else if (bazooka.activeSelf)
        {
            firstplayerhealthAmount = Bazooka_Script.bazookaHealthAmount + PlayerPrefs.GetInt("Bazookahealthlevel") * 50;
        }

        else if (constructor.activeSelf)
        {
            firstplayerhealthAmount = Constructor_Script.constructorHealthAmount + PlayerPrefs.GetInt("Constructorhealthlevel") * 50;
        }

        else if (girlstudent.activeSelf)
        {
            firstplayerhealthAmount = GirlStudent_Script.girlstudentHealthAmount + PlayerPrefs.GetInt("GirlStudenthealthlevel") * 50;
        }

        else if (grenade.activeSelf)
        {
            firstplayerhealthAmount = Grenademan_Script.grenadeHealthAmount + PlayerPrefs.GetInt("Grenadehealthlevel") * 50;
        }

        else if (lasergun.activeSelf)
        {
            firstplayerhealthAmount = LaserGun_Script.lasergunHealthAmount + PlayerPrefs.GetInt("Lasergunhealthlevel") * 50;
        }

        else if (lasersword.activeSelf)
        {
            firstplayerhealthAmount = Lasersword_Script.laserswordHealthAmount + PlayerPrefs.GetInt("Laserswordhealthlevel") * 50;
        }

        else if (nurse.activeSelf)
        {
            firstplayerhealthAmount = Nurse_Script.nurseHealthAmount + PlayerPrefs.GetInt("Nursehealthlevel") * 50;
        }

        else if (samurai.activeSelf)
        {
            firstplayerhealthAmount = Samurai_Script.samuraiHealthAmount + PlayerPrefs.GetInt("Samuraihealthlevel") * 50;
        }

        else if (teacher.activeSelf)
        {
            firstplayerhealthAmount = Teacher_Script.teacherHealthAmount + PlayerPrefs.GetInt("Teacherhealthlevel") * 50;
        }

        else if (viking2.activeSelf)
        {
            firstplayerhealthAmount = Viking2_Script.viking2HealthAmount + PlayerPrefs.GetInt("Viking2healthlevel") * 50;
        }

        else if (firewizard.activeSelf)
        {
            firstplayerhealthAmount = Firewizard_Script.firewizardHealthAmount + PlayerPrefs.GetInt("Firewizardhealthlevel") * 50;
        }

        else if (electricwizard.activeSelf)
        {
            firstplayerhealthAmount = ElectricWizard_Script.electricwizardHealthAmount + PlayerPrefs.GetInt("Electricwizardhealthlevel") * 50;
        }

        else if (poisonwizard.activeSelf)
        {
            firstplayerhealthAmount = Poisonwizard_Script.poisonwizardHealthAmount + PlayerPrefs.GetInt("Poisonwizardhealthlevel") * 50;
        }

        else if (artist.activeSelf)
        {
            firstplayerhealthAmount = Artist_Script.artistHealthAmount + PlayerPrefs.GetInt("Artisthealthlevel") * 50;
        }

        else if (baseballBall.activeSelf)
        {
            firstplayerhealthAmount = BaseballBall_Script.baseballBallHealthAmount + PlayerPrefs.GetInt("BaseballBallhealthlevel") * 50;
        }

        else if (basketball.activeSelf)
        {
            firstplayerhealthAmount = Basketball_Script.basketballHealthAmount + PlayerPrefs.GetInt("Basketballhealthlevel") * 50;
        }

        else if (demon.activeSelf)
        {
            firstplayerhealthAmount = Demon_Script.demonHealthAmount + PlayerPrefs.GetInt("Demonhealthlevel") * 50;
        }

        else if (englandsoldier.activeSelf)
        {
            firstplayerhealthAmount = EnglandSoldier_Script.englandsoldierHealthAmount + PlayerPrefs.GetInt("Englandsoldierhealthlevel") * 50;
        }

        else if (gangsterboss.activeSelf)
        {
            firstplayerhealthAmount = GangsterBoss_Script.gangsterbossHealthAmount + PlayerPrefs.GetInt("Gangsterbosshealthlevel") * 50;
        }

        else if (girlninja.activeSelf)
        {
            firstplayerhealthAmount = GirlNinja_Script.girlninjaHealthAmount + PlayerPrefs.GetInt("Girlninjahealthlevel") * 50;
        }

        else if (indian.activeSelf)
        {
            firstplayerhealthAmount = Indian_Script.indianHealthAmount + PlayerPrefs.GetInt("Indianhealthlevel") * 50;
        }

        else if (pirate.activeSelf)
        {
            firstplayerhealthAmount = Pirate_Script.pirateHealthAmount + PlayerPrefs.GetInt("Piratehealthlevel") * 50;
        }

        else if (piratecaptain.activeSelf)
        {
            firstplayerhealthAmount = PirateCaptain_Script.piratecaptainHealthAmount + PlayerPrefs.GetInt("Piratecaptainhealthlevel") * 50;
        }

        else if (police.activeSelf)
        {
            firstplayerhealthAmount = Police_Script.policeHealthAmount + PlayerPrefs.GetInt("Policehealthlevel") * 50;
        }

        else if (rocker.activeSelf)
        {
            firstplayerhealthAmount = Rocker_Script.rockerHealthAmount + PlayerPrefs.GetInt("Rockerhealthlevel") * 50;
        }

        else if (ski.activeSelf)
        {
            firstplayerhealthAmount = Ski_Script.skiHealthAmount + PlayerPrefs.GetInt("Skihealthlevel") * 50;
        }

        else if (vampire.activeSelf)
        {
            firstplayerhealthAmount = Vampire_Script.vampireHealthAmount + PlayerPrefs.GetInt("Vampirehealthlevel") * 50;
        }


        else
        {
            firstplayerhealthAmount = Move2.pistolHealthAmount + PlayerPrefs.GetInt("Pistolhealthlevel") * 50;
        }
    }

    void Update()
    {
        healthText.text = playerhealthAmount.ToString() + "/" + firstplayerhealthAmount.ToString();

        if (ShakeElapsedTime > 0)
        {
            virtualCameraNoise.m_AmplitudeGain = ShakeAmplitude;
            virtualCameraNoise.m_FrequencyGain = ShakeFrequency;

            ShakeElapsedTime -= Time.deltaTime;
        }
        else
        {
            virtualCameraNoise.m_AmplitudeGain = 0f;
            ShakeElapsedTime = 0f;
        }

        if (basiczombie_attack == false)
        {
            CancelInvoke("basic_zombie_hurt");
            whiteFade.CrossFadeAlpha(0, 4, false);
        }

        if (flyzombie_attack == false)
        {
            CancelInvoke("fly_zombie_hurt");
            whiteFade.CrossFadeAlpha(0, 4, false);
        }

        if (parkourzombie_attack == false)
        {
            CancelInvoke("parkour_zombie_hurt");
            whiteFade.CrossFadeAlpha(0, 4, false);
        }

        if (sneakyzombie_attack == false)
        {
            CancelInvoke("sneaky_zombie_hurt");
            whiteFade.CrossFadeAlpha(0, 4, false);
        }

        if (primitivezombie_attack == false)
        {
            CancelInvoke("primitive_zombie_hurt");
            whiteFade.CrossFadeAlpha(0, 4, false);
        }

        if (canonzombie_attack == false)
        {
            CancelInvoke("canon_zombie_hurt");
            whiteFade.CrossFadeAlpha(0, 4, false);
        }

        if (shieldzombie_attack == false)
        {
            CancelInvoke("shield_zombie_hurt");
            whiteFade.CrossFadeAlpha(0, 4, false);
        }

        if (canonflyzombie_attack == false)
        {
            CancelInvoke("canonfly_zombie_hurt");
            whiteFade.CrossFadeAlpha(0, 4, false);
        }

        if (jetpackzombie_attack == false)
        {
            CancelInvoke("jetpack_zombie_hurt");
            whiteFade.CrossFadeAlpha(0, 4, false);
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("basic_zombie(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 1(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 2(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 3(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 4(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 5(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 6(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 7(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 8(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 9(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 10(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 11(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 12(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 13(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 14(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 15(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 16(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 17(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 18(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 19(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 20(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 21(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 22(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 23(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 24(Clone)") ||
            col.gameObject.name.Equals("basic_zombie 25(Clone)"))
        {
            InvokeRepeating("basic_zombie_hurt", 0, 1.0f);
            basiczombie_attack = true;
        }

        if (col.gameObject.name.Equals("fly_zombie(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 1(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 2(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 3(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 4(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 5(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 6(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 7(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 8(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 9(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 10(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 11(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 12(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 13(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 14(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 15(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 16(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 17(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 18(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 19(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 20(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 21(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 22(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 23(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 24(Clone)") ||
            col.gameObject.name.Equals("fly_zombie 25(Clone)"))
        {
            InvokeRepeating("fly_zombie_hurt", 0, 1.0f);
            flyzombie_attack = true;
        }

        if (col.gameObject.name.Equals("fast_zombie(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 1(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 2(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 3(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 4(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 5(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 6(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 7(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 8(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 9(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 10(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 11(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 12(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 13(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 14(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 15(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 16(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 17(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 18(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 19(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 20(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 21(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 22(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 23(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 24(Clone)") ||
            col.gameObject.name.Equals("fast_zombie 25(Clone)"))
        {
            SoundManagerScript.PlaySound(hurtsound);
            ShakeElapsedTime = ShakeDuration;
            playerhealthAmount -= fast_zombie_script.fgz_attack;
            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("sneaky_zombie(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 1(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 2(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 3(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 4(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 5(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 6(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 7(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 8(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 9(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 10(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 11(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 12(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 13(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 14(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 15(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 16(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 17(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 18(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 19(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 20(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 21(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 22(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 23(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 24(Clone)") ||
            col.gameObject.name.Equals("sneaky_zombie 25(Clone)"))
        {
            InvokeRepeating("sneaky_zombie_hurt", 0, 1.0f);
            sneakyzombie_attack = true;
        }

        if (col.gameObject.name.Equals("parkour_zombie(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 1(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 2(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 3(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 4(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 5(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 6(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 7(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 8(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 9(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 10(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 11(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 12(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 13(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 14(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 15(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 16(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 17(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 18(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 19(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 20(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 21(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 22(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 23(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 24(Clone)") ||
            col.gameObject.name.Equals("parkour_zombie 25(Clone)"))
        {
            InvokeRepeating("parkour_zombie_hurt", 0, 1.0f);
            parkourzombie_attack = true;
        }

        if (col.gameObject.name.Equals("canon_zombie(Clone)"))
        {
            InvokeRepeating("canon_zombie_hurt", 0, 1.0f);
            canonzombie_attack = true;
        }

        if (col.gameObject.name.Equals("Rock(Clone)"))
        {
            InvokeRepeating("primitive_zombie_hurt", 0, 1.0f);
            primitivezombie_attack = true;
        }

        if (col.gameObject.name.Equals("shield_zombie(Clone"))
        {
            InvokeRepeating("shield_zombie_hurt", 0, 1.0f);
            shieldzombie_attack = true;
        }

        if (col.gameObject.name.Equals("canonfly_zombie(Clone)"))
        {
            InvokeRepeating("canon_zombie_hurt", 0, 1.0f);
            canonflyzombie_attack = true;
        }

        if (col.gameObject.name.Equals("jetpack_zombie(Clone)"))
        {
            InvokeRepeating("jetpack_zombie_hurt", 0, 1.0f);
            jetpackzombie_attack = true;
        }


    }

    void OnTriggerExit2D(Collider2D col)
    {
        basiczombie_attack = false;
        flyzombie_attack = false;
        sneakyzombie_attack = false;
        parkourzombie_attack = false;
        canonzombie_attack = false;
        primitivezombie_attack = false;
        shieldzombie_attack = false;
        canonflyzombie_attack = false;
        jetpackzombie_attack = false;
    }

    void basic_zombie_hurt()
    {
        ShakeElapsedTime = ShakeDuration;
        whiteFade.CrossFadeAlpha(1, 0, false);
        SoundManagerScript.PlaySound(hurtsound);
        playerhealthAmount -= basic_zombie_movement.bz_attack;
    }

    void fly_zombie_hurt()
    {
        ShakeElapsedTime = ShakeDuration;
        whiteFade.CrossFadeAlpha(1, 0, false);
        SoundManagerScript.PlaySound(hurtsound);
        playerhealthAmount -= fly_zombie_script.fz_attack;
    }

    void sneaky_zombie_hurt()
    {
        ShakeElapsedTime = ShakeDuration;
        whiteFade.CrossFadeAlpha(1, 0, false);
        SoundManagerScript.PlaySound(hurtsound);
        playerhealthAmount -= sneaky_zombie_script.sz_attack;
    }

    void parkour_zombie_hurt()
    {
        ShakeElapsedTime = ShakeDuration;
        whiteFade.CrossFadeAlpha(1, 0, false);
        SoundManagerScript.PlaySound(hurtsound);
        playerhealthAmount -= parkour_zombie_script.pz_attack;
    }

    void canon_zombie_hurt()
    {
        ShakeElapsedTime = ShakeDuration;
        whiteFade.CrossFadeAlpha(1, 0, false);
        SoundManagerScript.PlaySound(hurtsound);
        playerhealthAmount -= canon_zombie_script.cz_attack;
    }

    void canonfly_zombie_hurt()
    {
        ShakeElapsedTime = ShakeDuration;
        whiteFade.CrossFadeAlpha(1, 0, false);
        SoundManagerScript.PlaySound(hurtsound);
        playerhealthAmount -= canonfly_zombie_script.cfz_attack;
    }

    void primitive_zombie_hurt()
    {
        ShakeElapsedTime = ShakeDuration;
        whiteFade.CrossFadeAlpha(1, 0, false);
        SoundManagerScript.PlaySound(hurtsound);
        playerhealthAmount -= primitive_zombie_script.pmz_attack;
    }

    void shield_zombie_hurt()
    {
        ShakeElapsedTime = ShakeDuration;
        whiteFade.CrossFadeAlpha(1, 0, false);
        SoundManagerScript.PlaySound(hurtsound);
        playerhealthAmount -= shield_zombie_script.shz_attack;
    }

    void jetpack_zombie_hurt()
    {
        ShakeElapsedTime = ShakeDuration;
        whiteFade.CrossFadeAlpha(1, 0, false);
        SoundManagerScript.PlaySound(hurtsound);
        playerhealthAmount -= jetpack_zombie_script.jz_attack;
    }
}
