using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, 0, "None", Resources.Load<Sprite>("RestartButton") ));

        //hunters
        cardList.Add(new Card(1, "MasterHunter", 10, 6, 6, "This is a MasterHunter", Resources.Load<Sprite>("Pullie") ));
        cardList.Add(new Card(2, "Hunter", 9, 5, 5, "This is a Hunter", Resources.Load<Sprite>("Hunter") ));
        cardList.Add(new Card(3, "ApprenticeHunter", 8, 4, 4, "This is an ApprenticeHunter", Resources.Load<Sprite>("Pullie") ));
        cardList.Add(new Card(4, "Caddy", 7, 3, 3, "This is a Caddy", Resources.Load<Sprite>("Hunter") ));
        cardList.Add(new Card(5, "Nova Scotia Duck Tolling Retriever", 6, 2, 2, "Pullie", Resources.Load<Sprite>("Duck") ));

        //ducks
        cardList.Add(new Card(6, "KingDuck", 10, 6, 6, "This is a KingDuck", Resources.Load<Sprite>("KingDuck") ));
        cardList.Add(new Card(7, "CrownPrincessDuck", 9, 5, 5, "This is a CrownPrincessDuck", Resources.Load<Sprite>("CrownPrincessDuck") ));
        cardList.Add(new Card(8, "SoldierDuck", 8, 4, 4, "This is a SoldierDuck", Resources.Load<Sprite>("Duck") ));
        cardList.Add(new Card(9, "Duck", 7, 3, 3, "This is a Duck", Resources.Load<Sprite>("Duck") ));
        cardList.Add(new Card(10, "Egg", 6, 2, 2, "This is an Egg", Resources.Load<Sprite>("Egg") ));

        //spells
        cardList.Add(new Card(11, "Warmth", 4, 0, 0, "Egg's attack and health increase to duck's", Resources.Load<Sprite>("Duck") ));
        cardList.Add(new Card(12, "PowerBooster", 5, 0, 0, "Attack increases for 2", Resources.Load<Sprite>("KingDuck") ));
        cardList.Add(new Card(13, "Remedy", 5, 0, 0, "Health increases for 2", Resources.Load<Sprite>("Duck") ));


    }

}