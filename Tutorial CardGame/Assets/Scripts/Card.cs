using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDesc;
    public Sprite spriteImage;


    public Card()
    {
    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDesc, Sprite SpriteImage)
    {
        this.id = Id;
        this.cardName = CardName;
        this.cost = Cost;
        this.power = Power;
        this.cardDesc = CardDesc;
        this.spriteImage = SpriteImage;
    }
}
