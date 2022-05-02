# AllCardsOnDeck2

PEDAC:
Problem
Example
Data (Data structures)
Algorithm
Code

Problem: Explorer Mode

Deck has 52 - a list with 52 elements that is made from the two strings detailed below
4 suits - a list with 4 elements
each "face" is A, 2, 3,... J, Q, K. - a list with 13 elements
the last two strings have to be explicitly in the document for the first string to be able to run.

When the deck is created and you can show each string as "Ace of Hearts", "Jack of Clubs", "2 of..." then create a method to shuffle the cards, using Fisher Yates.
Then show the first two cards after the shuffle.

#ExampleData:

    Ace of Spades
    2 of Spades
    3 of Spades
    4 of Spades
    5 of Spades
    6 of Spades
    7 of Spades
    8 of Spades
    9 of Spades
    10 of Spades
    Jack of Spades
    Queen of Spades
    King of Spades
    ...
    "- There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
    There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King". -"

Data (Data Structure)

    'string'
    'list'
    loops

/_ this whole process should taken one - two hours _/

Algorithm_A - Make a list of 52 cards = deck - make 52 distinct cards from the #ExampleData - Shuffle those cards according to the Fisher Yates
numberOfCards = length of our deck

        for rightIndex from numberOfCards - 1 down to 1 do:
        leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. (See the section "How do we get a random integer")

        Now swap the values at rightIndex and leftIndex by doing this:
        leftCard = the value from deck[leftIndex]
        rightCard = the value from deck[rightIndex]
        deck[rightIndex] = leftCard
        deck[leftIndex] = rightCard
    - first card = deck[0]
    - second card = deck[1]
    - print first and second cards

Algorithm_B

- Make a list of the four suits and call it "suits'
- make a list of the 13 faces and call them "faces"
- make a list of the two strings together and all it "deck"
  - make a loop that goes through the list "suits"
    - make a list that goes through the list "faces"
    - for each face, make a new string
    - format CS $"{face} of {suit}"
    - add that new string to the end of the deck list
- same as Algorithm_A
