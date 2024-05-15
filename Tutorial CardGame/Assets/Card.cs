using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDesc;


    public Card()
    {
    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDesc)
    {
        this.id = Id;
        this.cardName = CardName;
        this.cost = Cost;
        this.power = Power;
        this.cardDesc = CardDesc;
    }
}
