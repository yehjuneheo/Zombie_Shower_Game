using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Potion : MonoBehaviour
{
    public float MoreSpeedAmount = 2f;
    public float MoreJumpAmount = 4f;

    private void Start()
    {
        MoreSpeedAmount += PlayerPrefs.GetInt("SpeedPotionLevel") / 2;
        MoreJumpAmount += PlayerPrefs.GetInt("SpeedPotionLevel") * 1;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Basic_Player"))
        {
            Move2.speed += MoreSpeedAmount;
            Move2.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Rifle_Player"))
        {
            Rifle_Script.speed += MoreSpeedAmount;
            Rifle_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Shotgun_Player"))
        {
            Shotgun_Script.speed += MoreSpeedAmount;
            Shotgun_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Sniper_Player"))
        {
            Sniper_Script.speed += MoreSpeedAmount;
            Sniper_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Minigun_Player"))
        {
            Minigun_Script.speed += MoreSpeedAmount;
            Minigun_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Tommygun_Player"))
        {
            Tommy_Script.speed += MoreSpeedAmount;
            Tommy_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Harpoon_Player"))
        {
            Harpoon_Script.speed += MoreSpeedAmount;
            Harpoon_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Laser_Player"))
        {
            Laser_Script.speed += MoreSpeedAmount;
            Laser_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Axe_Player"))
        {
            Axe_Script.speed += MoreSpeedAmount;
            Axe_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Baseball_Player"))
        {
            Baseball_Script.speed += MoreSpeedAmount;
            Baseball_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Bone_Player"))
        {
            Bone_Script.speed += MoreSpeedAmount;
            Bone_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Chef_Player"))
        {
            Chef_Script.speed += MoreSpeedAmount;
            Chef_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Farmer_Player"))
        {
            Farmer_Script.speed += MoreSpeedAmount;
            Farmer_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Mine_Player"))
        {
            MineWorker_Script.speed += MoreSpeedAmount;
            MineWorker_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Ninja_Player"))
        {
            Ninja_Script.speed += MoreSpeedAmount;
            Ninja_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Robber_Player"))
        {
            Robber_Script.speed += MoreSpeedAmount;
            Robber_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Sparta_Player"))
        {
            Sparta_Script.speed += MoreSpeedAmount;
            Sparta_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Bazooka_Player"))
        {
            Bazooka_Script.speed += MoreSpeedAmount;
            Bazooka_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Constructor_Player"))
        {
            Constructor_Script.speed += MoreSpeedAmount;
            Constructor_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("LaserGun_Player"))
        {
            LaserGun_Script.speed += MoreSpeedAmount;
            LaserGun_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("LaserSword_Player"))
        {
            Lasersword_Script.speed += MoreSpeedAmount;
            Lasersword_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Nurse_Player"))
        {
            Nurse_Script.speed += MoreSpeedAmount;
            Nurse_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("ElectricWizard_Player"))
        {
            ElectricWizard_Script.speed += MoreSpeedAmount;
            ElectricWizard_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("FireWizard_Player"))
        {
            Firewizard_Script.speed += MoreSpeedAmount;
            Firewizard_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("PoisonWizard_Player"))
        {
            Poisonwizard_Script.speed += MoreSpeedAmount;
            Poisonwizard_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("WindWizard_Player"))
        {
            Windwizard_Script.speed += MoreSpeedAmount;
            Windwizard_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("GirlStudent_Player"))
        {
            GirlStudent_Script.speed += MoreSpeedAmount;
            GirlStudent_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Grenade_Player"))
        {
            Grenademan_Script.speed += MoreSpeedAmount;
            Grenademan_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Rock_Player"))
        {
            Rockman_Script.speed += MoreSpeedAmount;
            Rockman_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Tree_Player"))
        {
            Treeman_Script.speed += MoreSpeedAmount;
            Treeman_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Samurai_Player"))
        {
            Samurai_Script.speed += MoreSpeedAmount;
            Samurai_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Viking1_Player"))
        {
            Viking1_Script.speed += MoreSpeedAmount;
            Viking1_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Viking2_Player"))
        {
            Viking2_Script.speed += MoreSpeedAmount;
            Viking2_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Teacher_Player"))
        {
            Teacher_Script.speed += MoreSpeedAmount;
            Teacher_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Artist_Player"))
        {
            Artist_Script.speed += MoreSpeedAmount;
            Artist_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("BaseballBall_Player"))
        {
            BaseballBall_Script.speed += MoreSpeedAmount;
            BaseballBall_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Basketball_Player"))
        {
            Basketball_Script.speed += MoreSpeedAmount;
            Basketball_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Demon_Player"))
        {
            Demon_Script.speed += MoreSpeedAmount;
            Demon_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("EnglandSoldier_Player"))
        {
            EnglandSoldier_Script.speed += MoreSpeedAmount;
            EnglandSoldier_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("GangsterBoss_Player"))
        {
            GangsterBoss_Script.speed += MoreSpeedAmount;
            GangsterBoss_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("GirlNinja_Player"))
        {
            GirlNinja_Script.speed += MoreSpeedAmount;
            GirlNinja_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("HealthTrainer_Player"))
        {
            HealthTrainer_Script.speed += MoreSpeedAmount;
            HealthTrainer_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Indian_Player"))
        {
            Indian_Script.speed += MoreSpeedAmount;
            Indian_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Pirate_Player"))
        {
            Pirate_Script.speed += MoreSpeedAmount;
            Pirate_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("PirateCaptain_Player"))
        {
            PirateCaptain_Script.speed += MoreSpeedAmount;
            PirateCaptain_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Police_Player"))
        {
            Police_Script.speed += MoreSpeedAmount;
            Police_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Rocker_Player"))
        {
            Rocker_Script.speed += MoreSpeedAmount;
            Rocker_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Ski_Player"))
        {
            Ski_Script.speed += MoreSpeedAmount;
            Ski_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Vampire_Player"))
        {
            Vampire_Script.speed += MoreSpeedAmount;
            Vampire_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Wrench_Player"))
        {
            Wrench_Script.speed += MoreSpeedAmount;
            Wrench_Script.jumpForce += MoreJumpAmount;

            Destroy(gameObject);
        }
    }
}
