using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cards = new List<Card>();

    void Awake(){
        cards.Add (new Card(0, 1, 1, "Human", "smart monkey"));
        cards.Add (new Card(1, 2, 3, "Elf", "is it fantasy???"));
        cards.Add (new Card(2, 2, 2, "Dwarf", "nice class"));
        cards.Add (new Card(3, 3, 4, "Demon", "hmm..."));
        cards.Add (new Card(4, 2, 2, "Angel", "wow 0_0"));
    }
}
