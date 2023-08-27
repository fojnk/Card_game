using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CurrentCard : MonoBehaviour
{
    public List<Card> currentCard = new List<Card>();
    public int currentCardId;
    public int id;
    public int cost;
    public int power;
    public string cardClass;
    public string cardName;
    public string cardDescription;

    public TMP_Text nameText;
    public TMP_Text costText;
    public TMP_Text powerText;
    public TMP_Text classText;
    public TMP_Text descriptionText;

    // Start is called before the first frame update
    void Start()
    {
        currentCard.Add( CardDataBase.cards[currentCardId]);
    }

    // Update is called once per frame
    void Update()
    {
        this.id = currentCard[0].id;
        print(currentCard[0].id);
        this.cost = currentCard[0].cost;
        this.power = currentCard[0].cost;
        this.cardDescription = currentCard[0].cardDescription;
        this.cardName = currentCard[0].cardName;
        this.cardClass = currentCard[0].cardClass;

        nameText.text = "" + cardName;
        costText.text = "" + cost;
        powerText.text = "" + power;
        classText.text = "" + cardClass;
        descriptionText.text = "" + cardDescription;
    }
}
