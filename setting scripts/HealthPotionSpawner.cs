using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] potions;
    int randomSpawnPoint, randomPotions;
    public static bool spawnAllowed;
    public float spawnspeed = 0.1f;
    public int nextTime = 1;
    public int nextUpdate = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad >= nextUpdate)
        {
            // Change the next update (current second+1)
            nextUpdate = Mathf.FloorToInt(Time.time) + nextTime;
            // Call your fonction
            UpdateEverySecond();
        }
    }

    void UpdateEverySecond()
    {
        InvokeRepeating("SpawnHealthPotion", 0f, 1 / spawnspeed);
    }

    // Update is called once per frame
    void SpawnHealthPotion()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomPotions = Random.Range(0, potions.Length);
            Instantiate(potions[randomPotions], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
        spawnspeed += Time.deltaTime / 10;
    }
}
