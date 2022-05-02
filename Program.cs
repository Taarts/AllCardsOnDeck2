using System;
using System.Collections.Generic;

namespace AllCardsOnDeck2

/* this is part of the review to practice more on writing the algorithm */
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Algorithm_A
            // - Make a list of 52 cards = deck
            //   var deck = new List<string>()
            //   {
            //   "Ace of Spades",
            //  "2 of Spades",
            //  "3 of Spades",
            //  "4 of Spades",
            //  "5 of Spades",
            //  "6 of Spades",
            //  "7 of Spades",
            //  "8 of Spades",
            //  "9 of Spades",
            //  "10 of Spades",
            //  "Jack of Spades",
            //  "Queen of Spades",
            //  "King of Spades",
            //  "Ace of Hearts",
            //  "2 of Hearts",
            //  "3 of Hearts",
            //  "4 of Hearts",
            //  "5 of Hearts",
            //  "6 of Hearts",
            //  "7 of Hearts",
            //  "8 of Hearts",
            //  "9 of Hearts",
            //  "10 of Hearts",
            //  "Jack of Hearts",
            //  "Queen of Hearts",
            //  "King of Hearts",
            //   "Ace of Diamonds",
            //  "2 of Diamonds",
            //  "3 of Diamonds",
            //  "4 of Diamonds",
            //  "5 of Diamonds",
            //  "6 of Diamonds",
            //  "7 of Diamonds",
            //  "8 of Diamonds",
            //  "9 of Diamonds",
            //  "10 of Diamonds",
            //  "Jack of Diamonds",
            //  "Queen of Diamonds",
            //  "King of Diamonds",
            //  "Ace of Clubs",
            //  "2 of Clubs",
            //  "3 of Clubs",
            //  "4 of Clubs",
            //  "5 of Clubs",
            //  "6 of Clubs",
            //  "7 of Clubs",
            //  "8 of Clubs",
            //  "9 of Clubs",
            //  "10 of Clubs",
            //  "Jack of Clubs",
            //  "Queen of Clubs",
            //  "King of Clubs",
            //   };

            // Algorithm_B 
            // - Make a list of the four suits and call it "suits' 
            var suits = new List<string>() {
              "Clubs", "Diamonds", "Hearts", "Spades"
            };
            // - make a list of the 13 faces and call them "faces" 
            var faces = new List<string>() {
            "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"
            };
            // - make a list of the two strings together and all it "deck" 
            var deck = new List<string>();
            //   - make a loop that goes through the list "suits" 
            foreach (var suit in suits)
            {
                //     - make a list that goes through the list "faces" 
                foreach (var face in faces)
                {
                    //     - for each face, make a new string, format CS $"{face} of {suit}"
                    var card = $"{face} of {suit}";
                    //     - add that new string to the end of the deck list 
                    deck.Add(card);
                }
            }

            /* ------------------------------------------------------------------*/
            // - Shuffle those cards according to the Fisher Yates
            //     numberOfCards = length of our deck
            var numberOfCards = deck.Count;
            //     for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                //     leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. (See the section "How do we get a random integer")
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                //     Now swap the values at rightIndex and leftIndex by doing this:
                //     leftCard = the value from deck[leftIndex]
                var leftCard = deck[leftIndex];
                //     rightCard = the value from deck[rightIndex]
                var rightCard = deck[rightIndex];
                //     deck[rightIndex] = leftCard
                deck[rightIndex] = leftCard;
                //     deck[leftIndex] = rightCard
                deck[leftIndex] = rightCard;
            }

            Console.WriteLine("Done shuffling");
            // - first card = deck[0]
            var firstCard = deck[0];
            // - second card = deck[1]
            var secondCard = deck[1];
            // - print first and second cards
            Console.WriteLine($"The first card is {firstCard}");
            Console.WriteLine($"The second card card is {secondCard}");



        }
    }
}
