using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCard : MonoBehaviour
{
    public List<Card> DisplayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDesc;

    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
