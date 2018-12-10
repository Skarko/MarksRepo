﻿using System;
using System.Collections.Generic;
using System.Linq;


var startingDeck = from s in Suits()
    from r in Ranks()
    select new { Suit = s, Rank = r };

foreach (var c in startingDeck)
{
Console.WriteLine(c);

}



static IEnumerable<string> Suits()
{
yield return "clubs";
yield return "diamonds";
yield return "hearts";
yield return "spades";
}

static IEnumerable<string> Ranks()
{
yield return "two";
yield return "three";
yield return "four";
yield return "five";
yield return "six";
yield return "seven";
yield return "eight";
yield return "nine";
yield return "ten";
yield return "jack";
yield return "queen";
yield return "king";
yield return "ace";
}



           