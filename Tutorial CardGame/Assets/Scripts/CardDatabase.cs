using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        //Debug.Log("gonna add to list");
        cardList.Add(new Card(0, "None", 0, 0, "Who?", Resources.Load<Sprite>("CohnJena") ));
        cardList.Add(new Card(1, "King", 2, 1, "The pinnacle of all Muscles, King", Resources.Load<Sprite>("King") ));
        cardList.Add(new Card(2, "MusclePhant", 3, 3, "Muscle Elephants boast great natural strength, those that strive for greater become nigh undefeatable", Resources.Load<Sprite>("MusclePhant") ));
        cardList.Add(new Card(3, "MuscleGorillaInc", 4, 1, "All gorillas strive for Perfection. Few can achieve it.", Resources.Load<Sprite>("MuscleGorillaInc") ));
        cardList.Add(new Card(4, "MuscleGorillaComplete", 2, 5, "At the pinnacle of all primates, the Muscle Gorilla stands proud.", Resources.Load<Sprite>("MuscleGorillaComplete") ));
        //Debug.Log("length is " + cardList.Count);
    }
    
}
