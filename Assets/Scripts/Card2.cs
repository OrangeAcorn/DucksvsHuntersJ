using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card2 : ScriptableObject
{
    public new string name;
    public string description;
    public int cost;
    public int attack;
    public int defence;


    
    public void Print()
    {
        Debug.Log(name + ": " + description + " The card costs: " + cost);
        
    }
}
