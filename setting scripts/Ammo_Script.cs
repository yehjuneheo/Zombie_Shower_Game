using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo_Script : MonoBehaviour
{
    public GameObject sniper;
    public GameObject basic;
    public GameObject rifle;
    public GameObject shotgun;
    public GameObject minigun;
    public GameObject tommy;
    public GameObject harpoon;
    public GameObject laser;
    public GameObject chef;
    public GameObject ninja;
    public GameObject bazooka;
    public GameObject girlstudent;
    public GameObject lasergun;
    public GameObject piratecaptain;
    public GameObject englandsoldier;
    public GameObject gangsterboss;

    public GameObject Reloadbutton;

    Text ammo;

    // Start is called before the first frame update
    void Start()
    {
        ammo = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (basic.activeSelf)
        {
            ammo.text = Pistol_Bullet.curAmmo + "/" + Pistol_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (sniper.activeSelf)
        {
            ammo.text = Sniper_Bullet.curAmmo + "/" + Sniper_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if(rifle.activeSelf)
        {
            ammo.text = Rifle_Bullet.curAmmo + "/" + Rifle_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (shotgun.activeSelf)
        {
            ammo.text = Shotgun_Bullet.curAmmo + "/" + Shotgun_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (minigun.activeSelf)
        {
            ammo.text = Minigun_Bullet.curAmmo + "/" + Minigun_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (tommy.activeSelf)
        {
            ammo.text = Tommy_Bullet.curAmmo + "/" + Tommy_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (harpoon.activeSelf)
        {
            ammo.text = Harpoon_Bullet.curAmmo + "/" + Harpoon_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (laser.activeSelf)
        {
            ammo.text = Laser_Bullet.curAmmo + "/" + Laser_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (bazooka.activeSelf)
        {
            ammo.text = Bazooka_Bullet.curAmmo + "/" + Bazooka_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (girlstudent.activeSelf)
        {
            ammo.text = GirlStudent_Bullet.curAmmo + "/" + GirlStudent_Bullet.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (lasergun.activeSelf)
        {
            ammo.text = LaserGun_Attack.curAmmo + "/" + LaserGun_Attack.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (piratecaptain.activeSelf)
        {
            ammo.text = PirateCaptain_Attack.curAmmo + "/" + PirateCaptain_Attack.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (englandsoldier.activeSelf)
        {
            ammo.text = EnglandSoldier_Attack.curAmmo + "/" + EnglandSoldier_Attack.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else if (gangsterboss.activeSelf)
        {
            ammo.text = GangsterBoss_Attack.curAmmo + "/" + GangsterBoss_Attack.maxAmmo;
            Reloadbutton.SetActive(true);
        }

        else
        {
            ammo.text = "";
            Reloadbutton.SetActive(false);
        }

    }
}
