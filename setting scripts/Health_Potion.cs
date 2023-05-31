using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Potion : MonoBehaviour
{
    public int HealAmount = 40;

    int HealthPotionLevel;

    private void Start()
    {
        HealthPotionLevel = PlayerPrefs.GetInt("HealthPotionLevel");
        HealAmount += PlayerPrefs.GetInt("HealthPotionLevel") * 20;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Basic_Player") ||
            col.gameObject.name.Equals("Rifle_Player") ||
            col.gameObject.name.Equals("Sniper_Player") ||
            col.gameObject.name.Equals("Shotgun_Player") ||
            col.gameObject.name.Equals("Minigun_Player") ||
            col.gameObject.name.Equals("Tommygun_Player") ||
            col.gameObject.name.Equals("Harpoon_Player") ||
            col.gameObject.name.Equals("Laser_Player") ||
            col.gameObject.name.Equals("Axe_Player") ||
            col.gameObject.name.Equals("Baseball_Player") ||
            col.gameObject.name.Equals("Bone_Player") ||
            col.gameObject.name.Equals("Chef_Player") ||
            col.gameObject.name.Equals("Farmer_Player") ||
            col.gameObject.name.Equals("Mine_Player") ||
            col.gameObject.name.Equals("Ninja_Player") ||
            col.gameObject.name.Equals("Robber_Player")||
            col.gameObject.name.Equals("Sparta_Player")||
            col.gameObject.name.Equals("Bazooka_Player") ||
            col.gameObject.name.Equals("Constructor_Player") ||
            col.gameObject.name.Equals("LaserGun_Player") ||
            col.gameObject.name.Equals("LaserSword_Player") ||
            col.gameObject.name.Equals("Nurse_Player") ||
            col.gameObject.name.Equals("ElectricWizard_Player") ||
            col.gameObject.name.Equals("FireWizard_Player") ||
            col.gameObject.name.Equals("PoisonWizard_Player") ||
            col.gameObject.name.Equals("WindWizard_Player") ||
            col.gameObject.name.Equals("GirlStudent_Player") ||
            col.gameObject.name.Equals("Grenade_Player") ||
            col.gameObject.name.Equals("Rock_Player") ||
            col.gameObject.name.Equals("Tree_Player") ||
            col.gameObject.name.Equals("Samurai_Player") ||
            col.gameObject.name.Equals("Viking1_Player") ||
            col.gameObject.name.Equals("Viking2_Player") ||
            col.gameObject.name.Equals("Teacher_Player") ||
            col.gameObject.name.Equals("Artist_Player") ||
            col.gameObject.name.Equals("BaseballBall_Player") ||
            col.gameObject.name.Equals("Basketball_Player") ||
            col.gameObject.name.Equals("Demon_Player") ||
            col.gameObject.name.Equals("EnglandSoldier_Player") ||
            col.gameObject.name.Equals("GangsterBoss_Player") ||
            col.gameObject.name.Equals("GirlNinja_Player") ||
            col.gameObject.name.Equals("HealthTrainer_Player") ||
            col.gameObject.name.Equals("Indian_Player") ||
            col.gameObject.name.Equals("Pirate_Player") ||
            col.gameObject.name.Equals("PirateCaptain_Player") ||
            col.gameObject.name.Equals("Police_Player") ||
            col.gameObject.name.Equals("Rocker_Player") ||
            col.gameObject.name.Equals("Ski_Player") ||
            col.gameObject.name.Equals("Vampire_Player") ||
            col.gameObject.name.Equals("Wrench_Player")
            )
        {
            Health_Player.playerhealthAmount += HealAmount;

            Destroy(gameObject);
        }
    }
}
