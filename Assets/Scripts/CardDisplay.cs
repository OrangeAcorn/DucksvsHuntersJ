using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card2 card;

    public Text nameText;
    public Text descriptionText;


    public Text costText;
    public Text attackText;
    public Text defenceText;

    //use this for initialization
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;


        costText.text = card.cost.ToString();
        attackText.text = card.attack.ToString();
        defenceText.text = card.defence.ToString();
        
    }
}
