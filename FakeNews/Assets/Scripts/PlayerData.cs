using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int profilePicID;

    public PlayerData (Player player)
    {
        playerName = player.playerName;
        profilePicID = player.profilePicID;

    }
}
