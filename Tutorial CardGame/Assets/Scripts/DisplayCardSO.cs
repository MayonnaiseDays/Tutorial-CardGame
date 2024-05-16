using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCardSO : MonoBehaviour
{
    public CardSO card;

    public TMP_Text nameText;
    public TMP_Text descText;
    public TMP_Text costText;
    public TMP_Text attackText;
    

    void Start()
    {
        nameText.text = card.name;
        descText.text = card.desc;
        costText.text = card.cost.ToString();
        attackText.text = card.attack.ToString();    
    }


}
