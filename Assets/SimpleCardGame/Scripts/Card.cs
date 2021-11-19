using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public (int, int, bool) param { get; }

    public Card(int value, int suite, bool isTrump) => param = (value, suite, isTrump);

    public static bool operator < (Card l, Card r) => l.param.Item1 < r.param.Item1 && l.param.Item3 == r.param.Item3 || !l.param.Item3 && r.param.Item3;
    public static bool operator > (Card l, Card r) => l.param.Item1 > r.param.Item1 && l.param.Item3 == r.param.Item3 || l.param.Item3 && !r.param.Item3; 
    public static bool operator == (Card l, Card r) => l.param.Item1 == r.param.Item1 && !l.param.Item3 && !r.param.Item3;
    public static bool operator != (Card l, Card r) => l.param.Item1 != r.param.Item1 || l.param.Item1 == r.param.Item1 && l.param.Item3 != r.param.Item3;

    public static string[] suites = { "Hearts", "Diamonds", "Clubs", "Spades" };

    public override string ToString()
    {
        
        string value = "";

        if (param.Item1 < 10) value = (param.Item1 + 2).ToString();
        else if (param.Item1 == 10) value = "J";
        else if (param.Item1 == 11) value = "Q";
        else if (param.Item1 == 12) value = "K";
        else if (param.Item1 == 13) value = "A";

        return value + " " + suites[param.Item2];
    }
}


