using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBack : MonoBehaviour
{
    public GameObject cardBack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the card is backwards
        if (DisplayCard.staticCardBack == true)
        {
            //look at the back
            cardBack.SetActive(true);
        }
        else
        {
            //dont look at the back
            cardBack.SetActive(false);
        }
    }
}
