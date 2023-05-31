using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Potion : MonoBehaviour
{
    private float attackLevelUp = 0.2f;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Basic_Player"))
        {
            Pistol_Bullet.pistoldamage += Pistol_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Rifle_Player"))
        {
            Rifle_Bullet.rifledamage += Rifle_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Shotgun_Player"))
        {
            Shotgun_Bullet.shotgundamage += Shotgun_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Sniper_Player"))
        {
            Sniper_Bullet.sniperdamage += Sniper_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Minigun_Player"))
        {
            Minigun_Bullet.minigundamage += Minigun_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Tommygun_Player"))
        {
            Tommy_Bullet.tommydamage += Tommy_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Harpoon_Player"))
        {
            Harpoon_Bullet.harpoondamage += Harpoon_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Laser_Player"))
        {
            Laser_Bullet.laserdamage += Laser_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Axe_Player"))
        {
            Axe_Attack.axedamage += Axe_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Bone_Player"))
        {
            Bone_Bullet.bonedamage += Bone_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Chef_Player"))
        {
            Chef_Bullet.chefdamage += Chef_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Mine_Player"))
        {
            Mine_Attack.minedamage += Mine_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Ninja_Player"))
        {
            Ninja_Bullet.ninjadamage += Ninja_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Robber_Player"))
        {
            Robber_Attack.robberdamage += Robber_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Sparta_Player"))
        {
            Sparta_Attack.spartadamage += Sparta_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Bazooka_Player"))
        {
            Bazooka_Bullet.bazookadamage += Bazooka_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Constructor_Player"))
        {
            Constructor_Attack.constructordamage += Constructor_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("LaserGun_Player"))
        {
            LaserGun_Attack.lasergundamage += LaserGun_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("LaserSword_Player"))
        {
            Lasersword_Attack.lasersworddamage += Lasersword_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Nurse_Player"))
        {
            Nurse_Attack.nursedamage += Nurse_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("ElectricWizard_Player"))
        {
            ElectricWizard_Attack.electricwizarddamage += ElectricWizard_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("FireWizard_Player"))
        {
            Firewizard_Attack.firewizarddamage += Firewizard_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("PoisonWizard_Player"))
        {
            Poisonwizard_Attack.poisonwizarddamage += Poisonwizard_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("GirlStudent_Player"))
        {
            GirlStudent_Bullet.girlstudentdamage += GirlStudent_Bullet.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Grenade_Player"))
        {
            Grenade_Attack.grenadedamage += Grenade_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Samurai_Player"))
        {
            Samurai_Attack.samuraidamage += Samurai_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Viking2_Player"))
        {
            Viking2_Attack.viking2damage += Viking2_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Teacher_Player"))
        {
            Teacher_Attack.teacherdamage += Teacher_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Artist_Player"))
        {
            Artist_Attack.artistdamage += Artist_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("BaseballBall_Player"))
        {
            BaseballBall_Attack.baseballBalldamage += BaseballBall_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Basketball_Player"))
        {
            Basketball_Attack.basketballdamage += Basketball_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Demon_Player"))
        {
            Demon_Attack.demondamage += Demon_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("EnglandSoldier_Player"))
        {
            EnglandSoldier_Attack.englandsoldierdamage += EnglandSoldier_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("GangsterBoss_Player"))
        {
            GangsterBoss_Attack.gangsterbossdamage += GangsterBoss_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("GirlNinja_Player"))
        {
            GirlNinja_Attack.girlninjadamage += GirlNinja_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Indian_Player"))
        {
            Indian_Attack.indiandamage += Indian_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Pirate_Player"))
        {
            Pirate_Attack.piratedamage += Pirate_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("PirateCaptain_Player"))
        {
            PirateCaptain_Attack.piratecaptaindamage += PirateCaptain_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Police_Player"))
        {
            Police_Attack.policedamage += Police_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Rocker_Player"))
        {
            Rocker_Attack.rockerdamage += Rocker_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Ski_Player"))
        {
            Ski_Attack.skidamage += Ski_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }

        if (col.gameObject.name.Equals("Vampire_Player"))
        {
            Vampire_Attack.vampiredamage += Vampire_Attack.plusdamage * (PlayerPrefs.GetInt("AttackPotionLevel") + 1) * attackLevelUp;

            Destroy(gameObject);
        }
    }
}
