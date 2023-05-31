using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    Vector3 localScale;
    public float health = 0f;
    public float startHealth = 0f;
    // Start is called before the first frame update
    void Start()
    {
        startHealth = Health_Player.playerhealthAmount;
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        health = Health_Player.playerhealthAmount;
        localScale.x = health / startHealth * 2;
        transform.localScale = localScale;
    }
}
