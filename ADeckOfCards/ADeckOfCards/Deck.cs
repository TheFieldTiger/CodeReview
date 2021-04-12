using System;
using System.Collections.Generic;

namespace ADeckOfCards
{
    class Deck
    {
        static int[] suits = { 1, 2, 3, 4 };
        static List<Card> DeckOfCards = new List<Card>();
        static void Main(string[] args)
        {
            int trackingint = 1;
            IsEmpty(suits, DeckOfCards);
            Shuffles();
            //foreach(var thing in DeckOfCards)
            //{
            //    Console.WriteLine(thing.CardSubType+" of "+thing.CardType);
            //}
            while (trackingint != 53)
            {
                trackingint = trackingint + 1;
                Console.WriteLine("Type an option : [ Deal ]  [ Quit ]");
                String UserOption = Console.ReadLine();
                while (UserOption.ToLower() != "deal" && UserOption.ToLower() != "quit")
                {
                    Console.WriteLine("That was not a valid option, please enter deal or quit");
                    UserOption = Console.ReadLine();
                }

                if (UserOption.ToLower() == "deal")
                {
                    Deal();
                }
                else if (UserOption.ToLower() == "quit")
                {
                    System.Environment.Exit(0);
                }
            }
            Console.WriteLine("You have reached the end of the deck");
            Console.ReadLine();
            
        }

        //Creates a full deck if the deck is empty
        //Cards cuz I dont know what cards are : diamond 13, clubs 13, hearts 13, spades 13, these include the aces, kings, queens and jacks. 
        static void IsEmpty(int[] suits, List<Card> DeckOfCards)
        {
            //Just keeps track of if its diamonds, clubs, hearts or spades needed in the current loop
            string SuitSelected = "";
            
            //four loops, one for each suit
            for(int o = 0; o != 4; o++)
            {
                switch (suits[o])
                {
                    case 1:
                        SuitSelected = "Diamonds";
                        break;

                    case 2:
                        SuitSelected = "Clubs";
                        break;

                    case 3:
                        SuitSelected = "Hearts";
                        break;

                    case 4:
                        SuitSelected = "Spades";
                        break;
                }
                //loops 13 times for the current suit to add that suits cards to the deck array
                for(int i = 0; i != 13; i++)
                {
                    //handles the number cards
                    if (i > 0 && i < 10)
                    {
                        Card NumberCard = new Card();
                        NumberCard.CardType = SuitSelected;
                        NumberCard.CardSubType = (i + 1).ToString();
                        DeckOfCards.Add(NumberCard);
                    }

                    //handles the ace, king, queen and jack cards
                    switch (i)
                    {
                        case 0:
                            Card AceCard = new Card();
                            AceCard.CardType = SuitSelected;
                            AceCard.CardSubType = "Ace";
                            DeckOfCards.Add(AceCard);
                            break;

                        case 10:
                            Card KingCard = new Card();
                            KingCard.CardType = SuitSelected;
                            KingCard.CardSubType = "King";
                            DeckOfCards.Add(KingCard);
                            break;

                        case 11:
                            Card QueenCard = new Card();
                            QueenCard.CardType = SuitSelected;
                            QueenCard.CardSubType = "Queen";
                            DeckOfCards.Add(QueenCard);
                            break;

                        case 12:
                            Card JackCard = new Card();
                            JackCard.CardType = SuitSelected;
                            JackCard.CardSubType = "Jack";
                            DeckOfCards.Add(JackCard);
                            break;
                    }


                }
            }
            
        }

        //Shuffles the deck 
        public static void Shuffles()
        {
            DeckOfCards.Shuffle();
        }

        //Gives the user a single card from the deck and removes it from the top of the deck
        public static void Deal()
        {
            DeckOfCards[0].DisplayCard();
            DeckOfCards.RemoveAt(0);
        }
    }

    public static class ShuffleStuff
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    
}
