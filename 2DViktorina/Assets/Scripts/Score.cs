using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI correctText;
    [SerializeField] private Image healthSlider;
    [SerializeField] private Image losePanel;
    public static int correct;
    public static int wrong;
    private void Start()
    {
        correct = 0;
        wrong = 3;
    }
    private void Update()
    {
        correctText.text = "" + correct; 

        if (wrong >= 3)
        {
            healthSlider.fillAmount = 1f;
            wrong = 3;
        }
        if (wrong == 2)
        {
            healthSlider.fillAmount = 0.65f;
        }
        if (wrong == 1)
        {
            healthSlider.fillAmount = 0.35f;
        }
        if (wrong <= 0)
        {
            healthSlider.fillAmount = 0f;
            wrong = 0;
            losePanel.gameObject.SetActive(true);
        }
        if (correct > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", correct);
        }
    }
}
