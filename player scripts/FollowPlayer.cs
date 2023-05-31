using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
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
    public GameObject pickaxe;
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
    public GameObject fp;

    public string player;

    public bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        player = CharacterSelection.charName;

        if (player.Equals("Sniper"))
        {
            sniper.SetActive(true);
        }
        else if (player.Equals("Business Man"))
        {
            basic.SetActive(true);
        }
        else if (player.Equals("Rifle Soldier"))
        {
            rifle.SetActive(true);
        }
        else if (player.Equals("Cowboy"))
        {
            shotgun.SetActive(true);
        }

        else if (player.Equals("Crazy Shooter"))
        {
            minigun.SetActive(true);
        }

        else if (player.Equals("Gangster"))
        {
            tommy.SetActive(true);
        }

        else if (player.Equals("Fisher"))
        {
            harpoon.SetActive(true);
        }

        else if (player.Equals("Space Soldier"))
        {
            laser.SetActive(true);
        }

        else if (player.Equals("Wood Cutter"))
        {
            axe.SetActive(true);
        }

        else if (player.Equals("Man of Bone"))
        {
            bone.SetActive(true);
        }

        else if (player.Equals("Chef"))
        {
            chef.SetActive(true);
        }

        else if (player.Equals("Mine Worker"))
        {
            pickaxe.SetActive(true);
        }

        else if (player.Equals("Ninja"))
        {
            ninja.SetActive(true);
        }

        else if (player.Equals("Robber"))
        {
            robber.SetActive(true);
        }

        else if (player.Equals("Sparta Man"))
        {
            sparta.SetActive(true);
        }

        else if (player.Equals("Bazooka Soldier"))
        {
            bazooka.SetActive(true);
        }

        else if (player.Equals("Constructor"))
        {
            constructor.SetActive(true);
        }

        else if (player.Equals("Girl Student"))
        {
            girlstudent.SetActive(true);
        }

        else if (player.Equals("Grenade Soldier"))
        {
            grenade.SetActive(true);
        }

        else if (player.Equals("Space Captain"))
        {
            lasergun.SetActive(true);
        }

        else if (player.Equals("Space Warrior"))
        {
            lasersword.SetActive(true);
        }

        else if (player.Equals("Nurse"))
        {
            nurse.SetActive(true);
        }

        else if (player.Equals("Samurai"))
        {
            samurai.SetActive(true);
        }

        else if (player.Equals("Teacher"))
        {
            teacher.SetActive(true);
        }

        else if (player.Equals("Viking"))
        {
            viking2.SetActive(true);
        }

        else if (player.Equals("Fire Wizard"))
        {
            firewizard.SetActive(true);
        }

        else if (player.Equals("Electric Wizard"))
        {
            electricwizard.SetActive(true);
        }

        else if (player.Equals("Poison Wizard"))
        {
            poisonwizard.SetActive(true);
        }

        else if (player.Equals("Artist"))
        {
            artist.SetActive(true);
        }

        else if (player.Equals("Baseball Pitcher"))
        {
            baseballBall.SetActive(true);
        }

        else if (player.Equals("Basketball Player"))
        {
            basketball.SetActive(true);
        }

        else if (player.Equals("Demon"))
        {
            demon.SetActive(true);
        }

        else if (player.Equals("England Soldier"))
        {
            englandsoldier.SetActive(true);
        }

        else if (player.Equals("Gangster Boss"))
        {
            gangsterboss.SetActive(true);
        }

        else if (player.Equals("Ninja Girl"))
        {
            girlninja.SetActive(true);
        }

        else if (player.Equals("Native Indian"))
        {
            indian.SetActive(true);
        }

        else if (player.Equals("Pirate"))
        {
            pirate.SetActive(true);
        }

        else if (player.Equals("Pirate Captain"))
        {
            piratecaptain.SetActive(true);
        }

        else if (player.Equals("Police Officer"))
        {
            police.SetActive(true);
        }

        else if (player.Equals("Rocker"))
        {
            rocker.SetActive(true);
        }

        else if (player.Equals("Skier"))
        {
            ski.SetActive(true);
        }

        else if (player.Equals("Vampire"))
        {
            vampire.SetActive(true);
        }

        else
        {
            rifle.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Health_Player.playerhealthAmount <= 0)
        {
            GameManagerScript.gameEnded = true;
            gameObject.SetActive(false);
            sniper.SetActive(false);
            basic.SetActive(false);
            rifle.SetActive(false);
            shotgun.SetActive(false);
            minigun.SetActive(false);
            tommy.SetActive(false);
            laser.SetActive(false);
            harpoon.SetActive(false);
            axe.SetActive(false);
            bone.SetActive(false);
            chef.SetActive(false);
            pickaxe.SetActive(false);
            ninja.SetActive(false);
            robber.SetActive(false);
            sparta.SetActive(false);
            bazooka.SetActive(false);
            constructor.SetActive(false);
            girlstudent.SetActive(false);
            grenade.SetActive(false);
            lasergun.SetActive(false);
            lasersword.SetActive(false);
            nurse.SetActive(false);
            samurai.SetActive(false);
            teacher.SetActive(false);
            viking2.SetActive(false);
            firewizard.SetActive(false);
            electricwizard.SetActive(false);
            poisonwizard.SetActive(false);
            artist.SetActive(false);
            baseballBall.SetActive(false);
            basketball.SetActive(false);
            demon.SetActive(false);
            englandsoldier.SetActive(false);
            gangsterboss.SetActive(false);
            girlninja.SetActive(false);
            indian.SetActive(false);
            pirate.SetActive(false);
            piratecaptain.SetActive(false);
            police.SetActive(false);
            rocker.SetActive(false);
            ski.SetActive(false);
            vampire.SetActive(false);
        }

        if (player.Equals("Sniper"))
        {
            fp.transform.position = sniper.transform.position;
        }

        else if (player.Equals("Business Man"))
        {
            fp.transform.position = basic.transform.position;
        }

        else if (player.Equals("Rifle Soldier"))
        {
            fp.transform.position = rifle.transform.position;
        }

        else if (player.Equals("Cowboy"))
        {
            fp.transform.position = shotgun.transform.position;
        }

        else if (player.Equals("Crazy Shooter"))
        {
            fp.transform.position = minigun.transform.position;
        }

        else if (player.Equals("Gangster"))
        {
            fp.transform.position = tommy.transform.position;
        }

        else if (player.Equals("Fisher"))
        {
            fp.transform.position = harpoon.transform.position;
        }

        else if (player.Equals("Space Soldier"))
        {
            fp.transform.position = laser.transform.position;
        }

        else if (player.Equals("Wood Cutter"))
        {
            fp.transform.position = axe.transform.position;
        }

        else if (player.Equals("Man of Bone"))
        {
            fp.transform.position = bone.transform.position;
        }

        else if (player.Equals("Chef"))
        {
            fp.transform.position = chef.transform.position;
        }

        else if (player.Equals("Mine Worker"))
        {
            fp.transform.position = pickaxe.transform.position;
        }

        else if (player.Equals("Ninja"))
        {
            fp.transform.position = ninja.transform.position;
        }

        else if (player.Equals("Robber"))
        {
            fp.transform.position = robber.transform.position;
        }

        else if (player.Equals("Sparta Man"))
        {
            fp.transform.position = sparta.transform.position;
        }

        else if (player.Equals("Bazooka Soldier"))
        {
            fp.transform.position = bazooka.transform.position;
        }

        else if (player.Equals("Constructor"))
        {
            fp.transform.position = constructor.transform.position;
        }

        else if (player.Equals("Girl Student"))
        {
            fp.transform.position = girlstudent.transform.position;
        }

        else if (player.Equals("Grenade Soldier"))
        {
            fp.transform.position = grenade.transform.position;
        }

        else if (player.Equals("Space Captain"))
        {
            fp.transform.position = lasergun.transform.position;
        }

        else if (player.Equals("Space Warrior"))
        {
            fp.transform.position = lasersword.transform.position;
        }

        else if (player.Equals("Nurse"))
        {
            fp.transform.position = nurse.transform.position;
        }

        else if (player.Equals("Samurai"))
        {
            fp.transform.position = samurai.transform.position;
        }

        else if (player.Equals("Teacher"))
        {
            fp.transform.position = teacher.transform.position;
        }

        else if (player.Equals("Viking"))
        {
            fp.transform.position = viking2.transform.position;
        }

        else if (player.Equals("Fire Wizard"))
        {
            fp.transform.position = firewizard.transform.position;
        }

        else if (player.Equals("Electric Wizard"))
        {
            fp.transform.position = electricwizard.transform.position;
        }

        else if (player.Equals("Poison Wizard"))
        {
            fp.transform.position = poisonwizard.transform.position;
        }

        else if (player.Equals("Artist"))
        {
            fp.transform.position = artist.transform.position;
        }

        else if (player.Equals("Baseball Pitcher"))
        {
            fp.transform.position = baseballBall.transform.position;
        }

        else if (player.Equals("Basketball Player"))
        {
            fp.transform.position = basketball.transform.position;
        }

        else if (player.Equals("Demon"))
        {
            fp.transform.position = demon.transform.position;
        }

        else if (player.Equals("England Soldier"))
        {
            fp.transform.position = englandsoldier.transform.position;
        }

        else if (player.Equals("Gangster Boss"))
        {
            fp.transform.position = gangsterboss.transform.position;
        }

        else if (player.Equals("Ninja Girl"))
        {
            fp.transform.position = girlninja.transform.position;
        }

        else if (player.Equals("Native Indian"))
        {
            fp.transform.position = indian.transform.position;
        }

        else if (player.Equals("Pirate"))
        {
            fp.transform.position = pirate.transform.position;
        }

        else if (player.Equals("Pirate Captain"))
        {
            fp.transform.position = piratecaptain.transform.position;
        }

        else if (player.Equals("Police Officer"))
        {
            fp.transform.position = police.transform.position;
        }

        else if (player.Equals("Rocker"))
        {
            fp.transform.position = rocker.transform.position;
        }

        else if (player.Equals("Skier"))
        {
            fp.transform.position = ski.transform.position;
        }

        else if (player.Equals("Vampire"))
        {
            fp.transform.position = vampire.transform.position;
        }

        else
        {
            fp.transform.position = rifle.transform.position;
        }
    }

    public void RespawnGameObject()
    {
        gameObject.SetActive(true);

        player = CharacterSelection.charName;

        if (player.Equals("Sniper"))
        {
            sniper.SetActive(true);
        }
        else if (player.Equals("Business Man"))
        {
            basic.SetActive(true);
        }
        else if (player.Equals("Soldier"))
        {
            rifle.SetActive(true);
        }
        else if (player.Equals("Cowboy"))
        {
            shotgun.SetActive(true);
        }

        else if (player.Equals("Crazy Shooter"))
        {
            minigun.SetActive(true);
        }

        else if (player.Equals("Gangster"))
        {
            tommy.SetActive(true);
        }

        else if (player.Equals("Fisher"))
        {
            harpoon.SetActive(true);
        }

        else if (player.Equals("Space Soldier"))
        {
            laser.SetActive(true);
        }

        else if (player.Equals("Wood Cutter"))
        {
            axe.SetActive(true);
        }

        else if (player.Equals("Man of Bone"))
        {
            bone.SetActive(true);
        }

        else if (player.Equals("Chef"))
        {
            chef.SetActive(true);
        }

        else if (player.Equals("Mine Worker"))
        {
            pickaxe.SetActive(true);
        }

        else if (player.Equals("Ninja"))
        {
            ninja.SetActive(true);
        }

        else if (player.Equals("Robber"))
        {
            robber.SetActive(true);
        }

        else if (player.Equals("Sparta Man"))
        {
            sparta.SetActive(true);
        }

        else if (player.Equals("Bazooka Soldier"))
        {
            bazooka.SetActive(true);
        }

        else if (player.Equals("Constructor"))
        {
            constructor.SetActive(true);
        }

        else if (player.Equals("Girl Student"))
        {
            girlstudent.SetActive(true);
        }

        else if (player.Equals("Grenade Soldier"))
        {
            grenade.SetActive(true);
        }

        else if (player.Equals("Space Captain"))
        {
            lasergun.SetActive(true);
        }

        else if (player.Equals("Space Warrior"))
        {
            lasersword.SetActive(true);
        }

        else if (player.Equals("Nurse"))
        {
            nurse.SetActive(true);
        }

        else if (player.Equals("Samurai"))
        {
            samurai.SetActive(true);
        }

        else if (player.Equals("Teacher"))
        {
            teacher.SetActive(true);
        }

        else if (player.Equals("Viking"))
        {
            viking2.SetActive(true);
        }

        else if (player.Equals("Fire Wizard"))
        {
            firewizard.SetActive(true);
        }

        else if (player.Equals("Electric Wizard"))
        {
            electricwizard.SetActive(true);
        }

        else if (player.Equals("Poison Wizard"))
        {
            poisonwizard.SetActive(true);
        }

        else if (player.Equals("Artist"))
        {
            artist.SetActive(true);
        }

        else if (player.Equals("Baseball Pitcher"))
        {
            baseballBall.SetActive(true);
        }

        else if (player.Equals("Basketball Player"))
        {
            basketball.SetActive(true);
        }

        else if (player.Equals("Demon"))
        {
            demon.SetActive(true);
        }

        else if (player.Equals("England Soldier"))
        {
            englandsoldier.SetActive(true);
        }

        else if (player.Equals("Gangster Boss"))
        {
            gangsterboss.SetActive(true);
        }

        else if (player.Equals("Ninja Girl"))
        {
            girlninja.SetActive(true);
        }

        else if (player.Equals("Native Indian"))
        {
            indian.SetActive(true);
        }

        else if (player.Equals("Pirate"))
        {
            pirate.SetActive(true);
        }

        else if (player.Equals("Pirate Captain"))
        {
            piratecaptain.SetActive(true);
        }

        else if (player.Equals("Police Officer"))
        {
            police.SetActive(true);
        }

        else if (player.Equals("Rocker"))
        {
            rocker.SetActive(true);
        }

        else if (player.Equals("Skier"))
        {
            ski.SetActive(true);
        }

        else if (player.Equals("Vampire"))
        {
            vampire.SetActive(true);
        }

        else
        {
            rifle.SetActive(true);
        }
    }
}
