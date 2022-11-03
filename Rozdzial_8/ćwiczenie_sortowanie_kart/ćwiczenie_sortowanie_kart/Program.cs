using ćwiczenie_sortowanie_kart;

static void Main(string[] args)
{
    Random random = new Random();
    Console.WriteLine("Pięć losowych kart:");
    List<Card> cards = new List<Card>();
    for(int i=0; i<5; i++) { 
        cards.Add(new Card((Values)random.Next(1, 14), (Suits)random.Next(4)));
        Console.WriteLine(cards[i].Name);
    }
    Console.WriteLine();
    Console.WriteLine("Te same karty posortowane:");
    cards.Sort(new CardComparer_byValue());
    foreach(Card card in cards)
    {
        Console.WriteLine(card.Name);
    }
    Console.ReadKey();
}