using ćwiczenie_metody_przeciążone;
using System.Security.Cryptography.X509Certificates;

namespace ćwiczenie_metody_przeciążone {

    public class Program {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Values.Three, Suits.Clubs);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
            Console.WriteLine(doesItMatch);
        }
    }
}