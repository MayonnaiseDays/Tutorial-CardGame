using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    
    public List<Card> container = new List<Card>();
    public int x;
    public int deckSize;
    public List<Card> deck = new List<Card>();

    //the cards displayed. does NOT equal the amount of cards in deck, just a fraction
    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;

        //deck length
        for (int i = 0; i < 40; i++) 
        {
            x = Random.Range(1, 4);
            deck[i] = CardDatabase.cardList[x]
;        }
    }

    // Update is called once per frame
    void Update()
    {
        if(deckSize < 30)
        {
            cardInDeck1.SetActive(false);
        }
        if(deckSize < 20)
        {
            cardInDeck2.SetActive(false);
        }
        if(deckSize < 10)
        {
            cardInDeck3.SetActive(false);
        }
        if(deckSize < 5)
        {
            cardInDeck4.SetActive(false);
        }
    }

    public void Shuffle()
    {
        for (int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }
}
