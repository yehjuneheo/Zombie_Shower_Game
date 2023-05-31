using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Anim_Script : MonoBehaviour
{
    private Animator anim;
    private ParticleSystem burst;


    void Start()
    {
        anim = GetComponent<Animator>();
        burst = gameObject.GetComponent<ParticleSystem>();
    }

    public void Click()
    {
        burst.Play();
        anim.SetTrigger("Damage");
    }
}
