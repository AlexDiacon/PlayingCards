using System;

namespace PlayingCards
{
    public class PlayingCards
    {
        public int rank;
        public int suit;

        public static int Ace = 1;
        public static int Deuce = 2;
        public static int Three = 3;
        public static int Four = 4;
        public static int Five = 5;
        public static int Six = 6;
        public static int Seven = 7;
        public static int Eight = 8;
        public static int Nine = 9;
        public static int Ten = 10;
        public static int Jack = 11;
        public static int Queen = 12;
        public static int King = 13;

        public static int Diamonds = 1;
        public static int Clubs = 2;
        public static int Hearts = 3;
        public static int Spades = 4;

        public string Rank(int rank)
        {
            switch(rank)
            {
                case 1: return "Ace";
                case 2: return "Deuce";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Jack";
                case 12: return "Queen";
                case 13: return "King";
                default: return "invalid";
            }
        }
        public string Suit(int suit)
        {
            switch(suit)
            {
                case 1: return "Diamonds";
                case 2: return "Clubs";
                case 3: return "Hearts";
                case 4: return "Spades";
                default: return "invalid";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rank number (between 1 and 13) : ");
            int rank = int.Parse(Console.ReadLine());
            Console.Write("Suit number (between 1 and 4) : ");
            int suit = int.Parse(Console.ReadLine());
            PlayingCards card = new PlayingCards();
            Console.Write("Your card is " + card.Rank(rank) + " of " + card.Suit(suit));
        }
    }
}
