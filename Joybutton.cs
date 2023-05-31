using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joybutton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool isPressed;

    [HideInInspector]
    public bool Pressed;

    void Update()
    {
        if (Pressed)
        {
            isPressed = true;
        }
        {
            isPressed = false;
        }
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
