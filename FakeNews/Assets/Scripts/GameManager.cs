using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.ComponentModel;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    #region Singleton
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    #endregion
    [Header("Player")]
    public Player player;

    [Header("UI Manager")]
    public UI_Manager uiManager;

    [Header("Weather")]
    public List<Sprite> weatherIcons;

    [Header("Days")]
    public List<Day> days;
    public Day currentDay;

    private void Start()
    {
        player = GetComponent<Player>();
    }

    public void BeginDay()
    {
        ChooseWeather();
    }

    public void EndDay()
    {
        Day newDay = new Day();
        currentDay = newDay;
        days.Add(currentDay);
    }

    void ChooseWeather()
    {
        int randomWeather = Random.Range(0, weatherIcons.Count);
        uiManager.weatherIcon.sprite = weatherIcons[randomWeather];
    }
}
