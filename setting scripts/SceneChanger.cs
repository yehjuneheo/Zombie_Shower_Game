using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void To_Game_Scene()
    {
        SceneManager.LoadScene("Game_Scene");
    }

    public void To_Character_Selection()
    {
        SceneManager.LoadScene("Character_Selection");
    }

    public void To_Shop()
    {
        SceneManager.LoadScene("Shop_Scene2");
    }

    public void To_Shopping()
    {
        SceneManager.LoadScene("Shop_Scene");
    }

    public void To_PotionShop()
    {
        SceneManager.LoadScene("Potion_Shop");
    }

    public void To_Main()
    {
        SceneManager.LoadScene("Main_Screen");
    }
}
