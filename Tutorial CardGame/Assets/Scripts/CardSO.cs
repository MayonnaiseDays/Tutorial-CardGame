using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card")]
public class CardSO : ScriptableObject
{
    public new string name;
    public string desc;
    public int cost;
    public int attack;

    // Update is called once per frame
    public void Print()
    {
        
    }
}
