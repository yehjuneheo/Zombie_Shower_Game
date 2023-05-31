using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    public GameObject playButton;
    public GameObject optionButton;
    public GameObject shopButton;

    public GameObject OptionMenu;

    public GameObject QuitConfirmMenu;

    public AudioMixer audioMixer;

    public Slider slider;
    public TMP_Dropdown dropdown;
    public Toggle toggle;

    float SliderVal = 0;
    string Graphics = "Very High";
    int isFull = 1;


    public void CloseButtons()
    {
        playButton.SetActive(false);
        shopButton.SetActive(false);
        optionButton.SetActive(false);
    }

    public void showButtons()
    {
        playButton.SetActive(true);
        shopButton.SetActive(true);
        optionButton.SetActive(true);
    }

    public void showOption()
    {
        OptionMenu.SetActive(true);
    }

    public void closeOption()
    {
        OptionMenu.SetActive(false);
    }

    public void QuitConfirm()
    {
        QuitConfirmMenu.SetActive(true);
    }

    public void closeQuitConfirm()
    {
        QuitConfirmMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }



    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }


    public void GetQuality()
    {
        dropdown.value = PlayerPrefs.GetInt("Graphics");
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("Graphics", dropdown.value);
    }


    public void GetScreen()
    {
        if (PlayerPrefs.GetInt("isFull") == 1)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        if (isFullscreen == true)
        {
            isFull = 1;
        }
        else
        {
            isFull = 0;
        }
        PlayerPrefs.SetInt("isFull", isFull);
    }


    public void Get_Slider_Value()
    {
        slider.value = PlayerPrefs.GetFloat("SliderVal");
    }

    public void Set_Slider_Value()
    {
        PlayerPrefs.SetFloat("SliderVal", slider.value);
    }
}
