using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiSpriteMenu : MonoBehaviour
{
	public List<Sprite> spritesList;
    [SerializeField] private Image[] block;
    [SerializeField] private TextMeshProUGUI questionText;

    private void Start()
    {
        SpawnSprite();
    }
    private void Update()
    {
        if (Button.correctAnswer == 1)
        {
            SpawnSprite();
            Button.correctAnswer = 0;
        }
    }
    private void SpawnSprite()
    {
        spritesList = new List<Sprite>(Resources.LoadAll<Sprite>("Flags"));
        int k = Random.Range(0,4);
        for (int i = 0; i < 4; i++)
        {
            int j = Random.Range(0, spritesList.Count);
            Sprite go = spritesList[j];
            spritesList.Remove(go);
            block[i].sprite = go;
            block[i].name = go.name;
            if (k == i) // ?
            {
                questionText.text = go.name;
            }
        }
    } 
     
}
