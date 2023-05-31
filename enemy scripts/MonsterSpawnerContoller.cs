 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnerContoller : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] monsters;
    int randomSpawnPoint, randomMonster;
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
        InvokeRepeating("SpawnAMonster", 0f, 1 / spawnspeed);
    }

    // Update is called once per frame
    void SpawnAMonster()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomMonster = Random.Range(0, monsters.Length);
            Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
        spawnspeed += Time.deltaTime/10;
    }
}
