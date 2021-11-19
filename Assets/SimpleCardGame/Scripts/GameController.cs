using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    private int trump;
    private int firstPile;
    private int secondPile;

    private (List<Card>, List<Card>) playersDeck;

    private void Start()
    {
        PlayRound();
    }

    private void PlayRound()
    {
        trump = Random.Range(0, 3);
        
        playersDeck = MyFunc.Deal(MyFunc.Shuffle(new Deck(trump).deck));

        StartCoroutine(Game());
    }

    IEnumerator Game()
    {
        for (int i = 0; i < playersDeck.Item1.Count; i++)
        {
            ComparingCards(playersDeck.Item1[i], playersDeck.Item2[i]);
            yield return new WaitForSecondsRealtime(0.1f);
        }

        Debug.Log("Finall score: " + firstPile + " : " + secondPile);
    }



    private void ComparingCards(Card first, Card second)
    {
        if (first > second)
        {
            firstPile += 2;
            Debug.Log("First win " + first.ToString() + " > " + second.ToString() + "  trump is " + Card.suites[trump]);
        }
        else if (first < second)
        {
            secondPile += 2;
            Debug.Log("Secont win " + first.ToString() + " < " + second.ToString() + "  trump is " + Card.suites[trump]);
        }
        else
        {
            firstPile++;
            secondPile++;
            Debug.Log("Draw " + first.ToString() + " === " + second.ToString() + "  trump is " + Card.suites[trump]);
        }

    }
}
