using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


public class MyFunc
{
    public static Func<List<Card>, List<Card>> Shuffle = (deck) => deck.OrderBy(a => Guid.NewGuid()).ToList();

    public static Func<int, int, bool> TestForEquality = (x, y) => x == y;

    public static Func<List<Card>, (List<Card>, List<Card>)> Deal = (newDeck) => (newDeck.GetRange(0, newDeck.Count / 2), newDeck.GetRange(newDeck.Count / 2, newDeck.Count / 2));
}
