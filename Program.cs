using OOPAdventure;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language?.ChooseYourName);

string? name = Console.ReadLine();

if (name ==String.Empty)
{
    name = Text.Language?.DefaultName;
}

Player player = new Player(name);

// do
// {
//     Console.WriteLine($"Seriously dude, what is your name?");
//     name = Console.ReadLine();
    
// } while (name == String.Empty);

Console.WriteLine(Text.Language.Welcome , player.Name);

House house = new House(player); 

