using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string playerName;
    public Sprite profilePic;
    public int profilePicID;

    public void SetProfileID(string buttonName)
    {
        switch (buttonName)
        {
            case "0":
                profilePicID = 0;
                break;
            case "1":
                profilePicID = 1;
                break;
            case "2":
                profilePicID = 2;
                break;
            case "3":
                profilePicID = 3;
                break;
            case "4":
                profilePicID = 4;
                break;
            case "5":
                profilePicID = 5;
                break;
            case "6":
                profilePicID = 6;
                break;
            case "7":
                profilePicID = 7;
                break;
            case "8":
                profilePicID = 8;
                break;
            case "9":
                profilePicID = 9;
                break;
            case "10":
                profilePicID = 10;
                break;
            case "11":
                profilePicID = 11;
                break;
            case "12":
                profilePicID = 12;
                break;
            case "13":
                profilePicID = 13;
                break;
            case "14":
                profilePicID = 14;
                break;
            case "15":
                profilePicID = 15;
                break;
            case "16":
                profilePicID = 16;
                break;
            case "17":
                profilePicID = 17;
                break;
            case "18":
                profilePicID = 18;
                break;
            case "19":
                profilePicID = 19;
                break;
            case "20":
                profilePicID = 20;
                break;
            case "21":
                profilePicID = 21;
                break;
            case "22":
                profilePicID = 22;
                break;
        }

    }
}
