using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_zombie_health : MonoBehaviour
{
    private Transform bar;
    public basic_zombie_movement bm;
    public float health = 0f;
    public float startHealth = 0f;

    void Start()
    {
        bar = transform.Find("Bar");
        startHealth = bm.enemyhealthAmount;
    }

    void Update()
    {
        health = bm.enemyhealthAmount;
        bar.localScale = new Vector3(health / startHealth * 2, 1);
    }
}
