
using System.Collections.Generic;
using UnityEngine;


public class Deck : MonoBehaviour
{
    public int suitesQuantity { get; }
    public int suiteSize { get; }
    public List<Card> deck {get;}

    public Deck(int roundTrump)
    {
        suitesQuantity = 4;
        suiteSize = 13;

        deck = new List<Card>();

        for (int i = 0; i < suitesQuantity; i++)
        {
            for (int j = 0; j < suiteSize; j++)
            {
                deck.Add(new Card(j, i, MyFunc.TestForEquality(i, roundTrump)));
            }
        }
    }
}
