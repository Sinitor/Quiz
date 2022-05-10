using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public static float correctAnswer = 0;
    public AudioSource myFx;
    public AudioClip clickFx;
    public void Play()
    {
        if (text.text == gameObject.name)
        {
            Debug.Log("Yep");
            myFx.PlayOneShot(clickFx);
            correctAnswer = 1;
            Score.correct++;
        }
        else
        {
            Debug.Log("Wrong");
            correctAnswer = 0;
            Score.wrong--;
        }
    }
}
