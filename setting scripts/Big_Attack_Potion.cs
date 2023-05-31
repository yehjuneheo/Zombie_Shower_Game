using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big_Attack_Potion : MonoBehaviour
{
    /*
    public float StopTime = 5f;

    int BigAttackPotionLevel;

    public bool BigAttackUp = false;

    public float MoreAttackAmount;


    // Start is called before the first frame update
    void Start()
    {
        BigAttackPotionLevel = PlayerPrefs.GetInt("BigAttackPotionLevel");
        StopTime += PlayerPrefs.GetInt("BigAttackPotionLevel");
    }

    void Update()
    {
        if (BigAttackUp = true)
        {
            StartCoroutine(AttackUpOn());
            return;
        }
    }


    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Basic_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;

        }

        else if (col.gameObject.name.Equals("Rifle_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Shotgun_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Sniper_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Minigun_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Tommygun_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Harpoon_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Laser_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Axe_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Baseball_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Bone_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Chef_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Farmer_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Mine_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Ninja_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Robber_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Sparta_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Bazooka_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Constructor_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("LaserGun_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("LaserSword_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Nurse_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("ElectricWizard_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("FireWizard_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("PoisonWizard_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("WindWizard_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("GirlStudent_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Grenade_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Rock_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Tree_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Samurai_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Viking1_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Viking2_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else if (col.gameObject.name.Equals("Teacher_Player"))
        {
            Destroy(gameObject);
            BigAttackUp = true;
        }

        else
        {
            BigAttackUp = false;
        }
    }

    IEnumerator AttackUpOn()
    {
        Pistol_Bullet.pistoldamage += MoreAttackAmount;
        Rifle_Bullet.rifledamage += MoreAttackAmount;
        Shotgun_Bullet.shotgundamage += MoreAttackAmount;
        Sniper_Bullet.sniperdamage += MoreAttackAmount;
        Minigun_Bullet.minigundamage += MoreAttackAmount;
        Tommy_Bullet.tommydamage += MoreAttackAmount;
        Harpoon_Bullet.harpoondamage += MoreAttackAmount;
        Laser_Bullet.laserdamage += MoreAttackAmount;
        Axe_Attack.axedamage += MoreAttackAmount;
        Baseball_Attack.baseballdamage += MoreAttackAmount;
        Bone_Bullet.bonedamage += MoreAttackAmount;
        Chef_Bullet.chefdamage += MoreAttackAmount;
        Farmer_Attack.farmerdamage += MoreAttackAmount;
        Mine_Attack.minedamage += MoreAttackAmount;
        Ninja_Bullet.ninjadamage += MoreAttackAmount;
        Robber_Attack.robberdamage += MoreAttackAmount;
        Sparta_Attack.spartadamage += MoreAttackAmount;
        Bazooka_Bullet.bazookadamage += MoreAttackAmount;
        Constructor_Attack.constructordamage += MoreAttackAmount;
        LaserGun_Attack.lasergundamage += MoreAttackAmount;
        Lasersword_Attack.lasersworddamage += MoreAttackAmount;
        Nurse_Attack.nursedamage += MoreAttackAmount;
        Firewizard_Attack.firewizarddamage += MoreAttackAmount;
        Poisonwizard_Attack.poisonwizarddamage += MoreAttackAmount;
        Windwizard_Attack.windwizarddamage += MoreAttackAmount;
        GirlStudent_Bullet.girlstudentdamage += MoreAttackAmount;
        Grenade_Attack.grenadedamage += MoreAttackAmount;
        Rockman_Attack.rockmandamage += MoreAttackAmount;
        Treeman_Attack.treedamage += MoreAttackAmount;
        Samurai_Attack.samuraidamage += MoreAttackAmount;
        Viking1_Attack.viking1damage += MoreAttackAmount;
        Viking2_Attack.viking2damage += MoreAttackAmount;
        Teacher_Attack.teacherdamage += MoreAttackAmount;

        yield return new WaitForSeconds(StopTime);

        BigAttackUp = false;
        Pistol_Bullet.pistoldamage -= MoreAttackAmount;
        Rifle_Bullet.rifledamage -= MoreAttackAmount;
        Shotgun_Bullet.shotgundamage -= MoreAttackAmount;
        Sniper_Bullet.sniperdamage -= MoreAttackAmount;
        Minigun_Bullet.minigundamage -= MoreAttackAmount;
        Tommy_Bullet.tommydamage -= MoreAttackAmount;
        Harpoon_Bullet.harpoondamage -= MoreAttackAmount;
        Laser_Bullet.laserdamage -= MoreAttackAmount;
        Axe_Attack.axedamage -= MoreAttackAmount;
        Baseball_Attack.baseballdamage -= MoreAttackAmount;
        Bone_Bullet.bonedamage -= MoreAttackAmount;
        Chef_Bullet.chefdamage -= MoreAttackAmount;
        Farmer_Attack.farmerdamage -= MoreAttackAmount;
        Mine_Attack.minedamage -= MoreAttackAmount;
        Ninja_Bullet.ninjadamage -= MoreAttackAmount;
        Robber_Attack.robberdamage -= MoreAttackAmount;
        Sparta_Attack.spartadamage -= MoreAttackAmount;
        Bazooka_Bullet.bazookadamage -= MoreAttackAmount;
        Constructor_Attack.constructordamage -= MoreAttackAmount;
        LaserGun_Attack.lasergundamage -= MoreAttackAmount;
        Lasersword_Attack.lasersworddamage -= MoreAttackAmount;
        Nurse_Attack.nursedamage -= MoreAttackAmount;
        Firewizard_Attack.firewizarddamage -= MoreAttackAmount;
        Poisonwizard_Attack.poisonwizarddamage -= MoreAttackAmount;
        Windwizard_Attack.windwizarddamage -= MoreAttackAmount;
        GirlStudent_Bullet.girlstudentdamage -= MoreAttackAmount;
        Grenade_Attack.grenadedamage -= MoreAttackAmount;
        Rockman_Attack.rockmandamage -= MoreAttackAmount;
        Treeman_Attack.treedamage -= MoreAttackAmount;
        Samurai_Attack.samuraidamage -= MoreAttackAmount;
        Viking1_Attack.viking1damage -= MoreAttackAmount;
        Viking2_Attack.viking2damage -= MoreAttackAmount;
        Teacher_Attack.teacherdamage -= MoreAttackAmount;
    }

    */
}
