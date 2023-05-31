using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;

public class Wall_Collision : MonoBehaviour
{
    public float ShakeDuration = 0.3f;
    public float ShakeAmplitude = 12f;
    public float ShakeFrequency = 4f;

    private float ShakeElapsedTime = 0f;

    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineBasicMultiChannelPerlin virtualCameraNoise;

    void Start()
    {
        if (VirtualCamera != null)
        {
            virtualCameraNoise = VirtualCamera.GetCinemachineComponent<Cinemachine.CinemachineBasicMultiChannelPerlin>();
        }
    }

    void Update()
    {
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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("BazookaBullet(Clone)") ||
            col.gameObject.name.Equals("Grenade(Clone)")
            )
        {
            ShakeElapsedTime = ShakeDuration;
            Destroy(col.gameObject);
        }
    }
}
