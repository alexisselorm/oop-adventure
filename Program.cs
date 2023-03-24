using OOPAdventure;

var language = new English();

Console.WriteLine(language.ChooseYourName);

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

