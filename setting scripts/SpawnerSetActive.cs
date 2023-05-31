using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSetActive : MonoBehaviour
{
    public void setActive()
    {
        gameObject.SetActive(true);
    }

    public void stopActive()
    {
        gameObject.SetActive(false);
    }
}
