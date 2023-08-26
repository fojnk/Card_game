using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private int id;
    private int cost;
    private int power;
    private string cardName;
    private string cardDescription;

    public Card(){

    }

    public Card (int id, int cost, int power, string cardName,  string cardDescription){
        this.id = id;
        this.cost = cost;
        this.power = power;
        this.cardName = cardName;
        this.cardDescription = cardDescription;
    }
}
