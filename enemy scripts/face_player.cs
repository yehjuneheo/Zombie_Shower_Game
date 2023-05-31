using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class face_player : MonoBehaviour
{
    public GameObject gun;
    private Vector3 target;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        target = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        Vector3 difference = target - gun.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        if (difference.x >= 0)
        {
            gun.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        }
        else
        {
            gun.transform.rotation = Quaternion.Euler(180.0f, 0.0f, -rotationZ);
        }
    }
}