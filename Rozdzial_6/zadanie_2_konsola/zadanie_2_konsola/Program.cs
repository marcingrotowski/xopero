using zadanie_2_konsola;

class Program
{
    static void Main(string[] args)
    {
        Owner owner = new Owner();
        Safe safe = new Safe();
        JewelThief jewelThief = new JewelThief();
        jewelThief.OpenSafe(safe, owner);
        Console.ReadKey();
    } 
}