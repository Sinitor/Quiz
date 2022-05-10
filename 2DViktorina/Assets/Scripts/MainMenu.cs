using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ButtonFlags()
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonCapital()
    {
        SceneManager.LoadScene(2);
    }
    public void LoseButton()
    {
        SceneManager.LoadScene(0);
    } 
}
