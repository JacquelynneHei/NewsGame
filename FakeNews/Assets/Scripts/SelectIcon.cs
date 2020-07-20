using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectIcon : MonoBehaviour
{
    public Image selected;
    public void SetPlayerIcon(Button button)
    {
        GameManager.instance.player.profilePic = button.image.sprite;
        GameManager.instance.player.SetProfileID(button.name);
    }

    public void SetPlayerName(InputField input)
    {
        GameManager.instance.player.playerName = input.text;
    }
}
