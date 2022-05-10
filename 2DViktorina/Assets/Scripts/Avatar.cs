using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Avatar : AvatarNumber
{
	public List<Sprite> avatarList;
    [SerializeField] private TextMeshProUGUI lvlText;
    [SerializeField] private Image avatarImage;

    public static int number;

    private void Start()
    {
        AvatarLVL();
        lvlText.text = "LVL " + number;
        avatarList = new List<Sprite>(Resources.LoadAll<Sprite>("Avatar"));
        avatarImage.sprite = avatarList[number];
    }
}
