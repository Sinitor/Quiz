using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarNumber : MonoBehaviour
{
    protected virtual void AvatarLVL()
    {
        if (PlayerPrefs.GetInt("Highscore") / 10 == 0)
        {
            Avatar.number = 0;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 1)
        {
            Avatar.number = 1;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 2)
        {
            Avatar.number = 2;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 3)
        {
            Avatar.number = 3;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 4)
        {
            Avatar.number = 4;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 5)
        {
            Avatar.number = 5;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 6)
        {
            Avatar.number = 6;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 7)
        {
            Avatar.number = 7;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 8)
        {
            Avatar.number = 8;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 9)
        {
            Avatar.number = 9;
        }
        if (PlayerPrefs.GetInt("Highscore") / 10 == 10)
        {
            Avatar.number = 10;
        }
    }
}
