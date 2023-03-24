using OOPAdventure;

Console.WriteLine($"Hello, what is your name?");

string? name = Console.ReadLine();

if (name ==String.Empty)
{
    name = "Rabid Dog";
}

Player player = new Player(name);

// do
// {
//     Console.WriteLine($"Seriously dude, what is your name?");
//     name = Console.ReadLine();
    
// } while (name == String.Empty);

Console.WriteLine($"Hello {player.Name}");

