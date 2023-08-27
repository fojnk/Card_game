using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cards = new List<Card>();

    void Awake(){
        cards.Add (new Card(0, 1, 1, "Human", "smart monkey", "soldier"));
        cards.Add (new Card(1, 2, 3, "Elf", "is it fantasy???", "soldier"));
        cards.Add (new Card(2, 2, 2, "Dwarf", "nice class", "soldier"));
        cards.Add (new Card(3, 3, 4, "Demon", "hmm...", "soldier"));
        cards.Add (new Card(4, 2, 2, "Angel", "wow 0_0", "soldier"));
    }
}
