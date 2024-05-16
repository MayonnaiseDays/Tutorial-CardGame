using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDesc;
    public Sprite spriteImage;

    public TMP_Text nameText;
    public TMP_Text costText;
    public TMP_Text powerText;
    public TMP_Text descText;
    public Image artImage;



    // Start is called before the first frame update
    void Start()
    {
        displayCard.Add(CardDatabase.cardList[displayId]);
        
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        power = displayCard[0].power;
        cardDesc = displayCard[0].cardDesc;
        spriteImage = displayCard[0].spriteImage;
        Debug.Log("psrite image is " + spriteImage.name);

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        powerText.text = " " + power;
        descText.text = " " + cardDesc;
        artImage.sprite = spriteImage;
    }

    // Update is called once per frame
    void Update()
    {


    }
}
