using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int id;
    public int cost;
    public int power;
    public string cardName;
    public string cardDescription;
    public string cardClass;

    public Card(){

    }

    public Card (int id, int cost, int power, string cardName,  string cardDescription, string cardClass){
        this.id = id;
        this.cost = cost;
        this.power = power;
        this.cardName = cardName;
        this.cardDescription = cardDescription;
        this.cardClass = cardClass;
    }
}
