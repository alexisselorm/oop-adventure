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

Actions.Instance.Register(new Go(house));

var run =true;

Room? lastRoom = null;

while ( run){
    if (lastRoom != house.currentRoom)
    {
        Console.WriteLine(house.currentRoom.ToString());
        lastRoom = house.currentRoom;
    }
    Console.WriteLine(Text.Language.WhatToDo);
    var input = Console.ReadLine().ToLower();

    if (input == Text.Language.Quit.ToLower()){
        run =false;
    }else{
        Actions.Instance.Execute(input.Split(" "));
    }
    
}