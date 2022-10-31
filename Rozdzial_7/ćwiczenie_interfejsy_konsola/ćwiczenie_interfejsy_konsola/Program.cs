// See https://aka.ms/new-console-template for more information
using ćwiczenie_interfejsy_konsola;

static void Main(string[] args)
{
    ScaryScary fingersTheClown = new ScaryScary("duże buty", 35);
    FunnyFunny someFunnyClown = fingersTheClown;
    IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
    someOtherScaryClown.Honk();
    Console.ReadKey();
}