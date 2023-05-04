using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card 
{
    public int id;
    public string cardName;
    public int cost;
    public int attack;
    public int defence;
    public string cardDescription;
    public Sprite spriteImage;
    //public bool spell;
    //public int damageDealtBySpell;


    public Card()
    {


    }


    public Card(int Id, string CardName, int Cost, int Attack, int Defence, string CardDescription, Sprite SpriteImage)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        attack = Attack;
        defence = Defence;
        cardDescription = CardDescription;
        spriteImage = SpriteImage;
        //spell = Spell;
        //damageDealtBySpell = DamageDealtBySpell;

    }

}


/*  //group's code
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id, cost;
    public int health, attack;
    public string cardName, cardDescription;
    public bool character;
    public bool spell;
    public int damageDealtBySpell;


    public Card(int id, bool character, string cardName, int cost, int attack, int health, string description, bool spell, int damageDealtBySpell)
    {
        this.id = id;
        this.character = character;
        this.cardName = cardName;
        this.cost = cost;
        this.attack = attack;
        this.health = health;
        this.description = description;
        this.spell = spell;
        this.damageDealtBySpell = damageDealtBySpell;
    }
}
*/
