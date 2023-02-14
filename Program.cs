using OOPAdventure;
Console.WriteLine("Hello, what is your name");

var name = Console.ReadLine();

if (name == String.Empty)
    name = "No Name";

var player = new Player(name);
Console.WriteLine($"Welcome {player.Name} to your OOP Adventure!");
