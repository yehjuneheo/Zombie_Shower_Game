using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;

public class Sniper_Bullet : MonoBehaviour
{
    public Transform barrel;
    public Rigidbody2D bullet;
    public float fireSpeed = 2000f;

    public Joybutton fireButton;
    public Joybutton reloadButton;
    public Joystick fireJoystick;

    public GameObject gun;
    private Vector3 target;

    public static float sniperdamage = 250f;

    public static float tempsniperdamage = 250f;

    public static float plusdamage = 30f;

    public static int maxAmmo = 7;
    public static int curAmmo = 7;
    public float reloadSpeed = 2f;

    private float nextTimeToFire = 0f;
    public float fireRate = 1f;

    public static bool reloading = false;

    public Transform shellExtractor;
    public Rigidbody2D shell;
    float randomExtractionForce, randomTorque;

    public GameObject flash;

    public float ShakeDuration = 0.3f;
    public float ShakeAmplitude = 7f;
    public float ShakeFrequency = 4f;

    private float ShakeElapsedTime = 0f;

    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineBasicMultiChannelPerlin virtualCameraNoise;

    void Start()
    {
        curAmmo = maxAmmo;

        sniperdamage += PlayerPrefs.GetInt("Sniperattacklevel") * plusdamage;

        if (VirtualCamera != null)
        {
            virtualCameraNoise = VirtualCamera.GetCinemachineComponent<Cinemachine.CinemachineBasicMultiChannelPerlin>();
        }
    }

    void Update()
    {

        float fireHorizontal = fireJoystick.Horizontal;
        float fireVertical = fireJoystick.Vertical;

        float rotationZ = Mathf.Atan2(fireVertical, fireHorizontal) * Mathf.Rad2Deg;

        if (fireHorizontal > 0)
        {
            gun.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        }
        else if (fireHorizontal < 0)
        {
            gun.transform.rotation = Quaternion.Euler(180.0f, 0.0f, -rotationZ);
        }


        if ((fireHorizontal >= 0.1 || fireHorizontal <= -0.1 || fireVertical >= 0.1 || fireVertical <= -0.1) && (Time.time >= nextTimeToFire) && (curAmmo > 0) && (!reloading))
        {
            ShakeElapsedTime = ShakeDuration;
            nextTimeToFire = Time.time + 1f / fireRate;
            Fire();
        }

        if (reloadButton.Pressed && reloading == false)
        {
            reloading = true;
            StartCoroutine(Reload());
            return;
        }

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
    }

    void Fire()
    {
        SoundManagerScript.PlaySound("gunshot");
        flash.SetActive(true);

        var firedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        firedBullet.AddForce(barrel.right * fireSpeed);
        curAmmo -= 1;

        InvokeRepeating("ResetFlash", 0.08f, 0);

        randomExtractionForce = Random.Range(2500f, 3000f);
        randomTorque = Random.Range(1000f, 1200f);
        ExtractShell();
    }

    IEnumerator Reload()
    {
        SoundManagerScript.PlaySound("gunreload");
        yield return new WaitForSeconds(reloadSpeed);
        curAmmo = maxAmmo;
        reloading = false;
    }

    void ExtractShell()
    {
        var extractShell = Instantiate(shell, shellExtractor.position, shellExtractor.rotation);
        extractShell.AddForce(shellExtractor.right * -1 * randomExtractionForce, ForceMode2D.Force);
        extractShell.AddTorque(randomTorque);
    }

    void ResetFlash()
    {
        flash.SetActive(false);
    }
}
