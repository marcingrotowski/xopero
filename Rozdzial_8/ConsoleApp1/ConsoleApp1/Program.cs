﻿using ConsoleApp1;

static void Main(string[] args)
{
    List<Shoe> shoeCloset = new List<Shoe>();

    shoeCloset.Add(new Shoe(){
        Style = Style.Sneakers, Color = "Czarny"
    });
    shoeCloset.Add(new Shoe(){
        Style = Style.Clogs,
        Color = "Brązowy"
    });
    shoeCloset.Add(new Shoe(){
        Style = Style.Wingtips,
        Color = "Czarny"
    });
    shoeCloset.Add(new Shoe(){
        Style = Style.Loafers,
        Color = "Biały"
    });
    shoeCloset.Add(new Shoe(){
        Style = Style.Loafers,
        Color = "Czerwony"
    });
    shoeCloset.Add(new Shoe(){
        Style = Style.Sneakers,
        Color = "Zielony"
    });

    int numberOfShoes = shoeCloset.Count;
    foreach(Shoe shoe in shoeCloset)
    {
        shoe.Style = Style.Flipflops;
        shoe.Color = "Pomarańczowy";
    }

    shoeCloset.RemoveAt(4);

    Shoe thirdShoe = shoeCloset[2];
    Shoe secondShoe = shoeCloset[1];
    shoeCloset.Clear();

    shoeCloset.Add(thirdShoe);
    if (shoeCloset.Contains(secondShoe))
    {
        Console.WriteLine("A to ci niespodzianka");
    }
}