using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [Header("Workday")]
    public Text timeText;
    public int hour;
    public int minute;
    public float timer;
    public float secondsPerMinute;

    [Header("Weather")]
    public Image weatherIcon;

    [Header("Setup Player")]
    public Text playerNameBottomLeft;
    public Text playerNameSideMenuTop;
    public Image playerIconTopRight;
    public Image playerIconBottomLeft;

    [Header("Side Menu Open/Close")]
    public Image sideMenu;
    public RectTransform openPosition;
    public RectTransform closePosition;
    public Button openCloseButton;

    [Header("Email")]
    public Text fromText;
    public Text subjectText;
    public Text emailBody;

    private void Start()
    {
        GameManager.instance.uiManager = this;
        playerNameBottomLeft.text = GameManager.instance.player.playerName;
        playerNameSideMenuTop.text = "Welcome, " + GameManager.instance.player.playerName;
        playerIconTopRight.sprite = GameManager.instance.player.profilePic;
        playerIconBottomLeft.sprite = GameManager.instance.player.profilePic;
        GameManager.instance.BeginDay();
    }

    private void Update()
    {
        UpdateTime();
    }

    void UpdateTime()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            if(minute < 59)
            {
                minute++;
            }
            else
            {
                minute = 0;

                if(hour < 12)
                {
                    hour++;
                }
                else if(hour >= 12)
                {
                    hour = 0;
                    hour++;
                }
                
            }

            timer = secondsPerMinute;
        }

        //update the UI
        timeText.text = hour.ToString().PadLeft(2, '0') + ":" + minute.ToString().PadLeft(2, '0');
        

        if(hour == 5)
        {
            Debug.Log("End of the day");
            GameManager.instance.EndDay();
        }
    }

    public void ToggleSideMenu()
    {
        RectTransform myRect = sideMenu.rectTransform;

        if (myRect.position == openPosition.position)
        {
            myRect.position = closePosition.position;
            sideMenu.rectTransform.position = closePosition.position;

            Vector3 myScale = openCloseButton.transform.localScale;
            myScale.x = 1;
            openCloseButton.transform.localScale = myScale;
        }
        else if (myRect.position == closePosition.position)
        {
            myRect.position = openPosition.position;
            sideMenu.rectTransform.position = openPosition.position;

            Vector3 myScale = openCloseButton.transform.localScale;
            myScale.x = -1;
            openCloseButton.transform.localScale = myScale;
        }


    }
}
