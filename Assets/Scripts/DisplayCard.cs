using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int attack;
    public int defence;
    public string cardDescription;
    public Sprite spriteImage;

    public Text nameText;
    public Text costText;
    public Text attackText;
    public Text defenceText;
    public Text descriptionText;
    public Image artImage;

    // Start is called before the first frame update
    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        attack = displayCard[0].attack;
        defence = displayCard[0].defence;
        cardDescription = displayCard[0].cardDescription;
        spriteImage = displayCard[0].spriteImage;


        nameText.text = " " + cardName;
        costText.text = " " + cost;
        attackText.text = " " + attack;
        defenceText.text = " " + defence;
        descriptionText.text = " " + cardDescription;
        artImage.sprite = spriteImage;
    }

    // Update is called once per frame
    void Update()
    {



    }
}

