using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Sound : MonoBehaviour
{
    float randomNumber;

    public float spawnspeed = 0.1f;
    public int nextTime = 1;

    public int nextUpdate = 1;


    void Update()
    {
        if (Time.timeSinceLevelLoad >= nextUpdate)
        {
            nextUpdate = Mathf.FloorToInt(Time.time) + nextTime;
            UpdateEverySecond();
        }
    }


    void UpdateEverySecond()
    {
        InvokeRepeating("Play_zombiemoan", 6f, 10f);
    }

    void Play_zombiemoan()
    {
        SoundManagerScript.PlaySound("zombiemoan");

        spawnspeed += Time.deltaTime / 10;
    }
}
