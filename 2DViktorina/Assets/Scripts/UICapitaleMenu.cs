using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UICapitaleMenu : MonoBehaviour
{
    public List<string> capitaleList;
    public List<Sprite> spritesList;

    [SerializeField] private TextMeshProUGUI[] text;
    [SerializeField] private Image[] block; 

    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private Image flag;
    private void Start()
    {
        SpawnCapitale();
    }
    private void Update()
    {
        if (Button.correctAnswer == 1)
        {
            SpawnCapitale();
            Button.correctAnswer = 0;
        }
    }
    private void SpawnCapitale()
    {
        capitaleList = new List<string>() { "Tirana", "Algiers", "Andorra la Vella", "Luanda", "Buenos Aires", "Yerevan", "Vienna", "Baku", "Nassau", "Manama",
        "Dhaka", "Minsk", "Brussels", "Sucre", "Sarajevo", "Gaborone", "Brasilia", "Sofia", "Ottawa", "Santiago", "Beijing", "Bogota", "Zagreb", "Nicosia",
        "Prague", "Copenhagen", "Quito", "Cairo", "Tallinn", "Helsinki", "Paris", "Tbilisi", "Berlin", "Athens", "Nuuk", "Hong Kong", "Budapest", "Reykjavik",
        "New Delhi", "Jakarta", "Tehran", "Baghdad", "Dublin", "Jerusalem", "Rome", "Tokyo", "Nur-Sultan", "Bishkek", "Riga", "Vilnius", "Skopje", "Kuala Lumpur",
        "Valletta", "Mexico City", "Chisinau", "Monaco", "Ulaanbaatar", "Amsterdam", "Wellington", "Pyongyang", "Oslo", "Lima", "Manila", "Warsaw", "Lisbon",
        "Doha", "Bucharest", "Moscow", "San Salvador", "Edinburgh", "Belgrade", "Singapore", "Bratislava", "Ljubljana", "Seoul", "Madrid", "Khartoum",
        "Stockholm", "Bern", "Bangkok", "Tunis", "Ankara", "Kyiv", "Abu Dhabi", "London", "Washington", "Tashkent", "Vatican", "Caracas", "Hanoi"}; 

        spritesList = new List<Sprite>(Resources.LoadAll<Sprite>("Flags"));

        int k = Random.Range(0, 4);
        for (int i = 0; i < 4; i++)
        {
            int j = Random.Range(0, capitaleList.Count);
            string go = capitaleList[j];
            Sprite goes = spritesList[j];
            capitaleList.Remove(go);
            spritesList.Remove(goes);
            text[i].text = go;
            block[i].name = goes.name;
            if (k == i) // ?
            { 
                flag.sprite = goes;
                flag.name = goes.name;
                questionText.text = flag.name;
            }
        }
    } 
}
