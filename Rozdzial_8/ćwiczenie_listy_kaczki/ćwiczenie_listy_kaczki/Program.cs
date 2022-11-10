using ćwiczenie_listy_kaczki;

namespace ćwiczenie_listy_kaczki { 

    class Program
    {
        static void Main(string[] args) {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck(){Kind = KindOfDuck.Mallard, Size = 17},
                new Duck(){Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck(){Kind = KindOfDuck.Decoy, Size = 14},
                new Duck(){Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck(){Kind = KindOfDuck.Mallard, Size = 14},
                new Duck(){Kind = KindOfDuck.Decoy, Size = 13},
            };
            static void PrintDucks(List<Duck> ducks)
            {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.Size.ToString() + "-centrymetrowa kaczka " + duck.Kind.ToString());
            Console.WriteLine("Koniec kaczek!");
            }
        }
    }
}