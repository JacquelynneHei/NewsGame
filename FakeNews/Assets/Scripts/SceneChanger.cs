using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Login()
    {

    }

    public void Register()
    {
        SceneManager.LoadScene("Register");
    }

    public void Settings()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SaveSystem.SavePlayer(GameManager.instance.player);

        SceneManager.LoadScene("Main");
    }
}
