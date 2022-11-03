using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_metody_przeciążone
{
    public enum Suits
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds,
    }

    public enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    public class Card
    {
        public Values Value { get; set; }
        public Suits Suit { get; set; }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }
        public static bool DoesCardMatch(Card CardToCheck, Suits Suit)
        {
            if (CardToCheck.Suit == Suit)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card CardToCheck, Values Value)
        {
            if (CardToCheck.Value == Value)
                return true;
            else
                return false;
        }
    }
}
