namespace OOPAdventure;

public partial class House {

    public Room currentRoom { get; set; }
    public void GoToRoom(int index){
        if (currentRoom != null)
            currentRoom.Visited = true;
        currentRoom = Rooms[index];

    }

    public void GoToStartingRoom(){
        GoToRoom(_rnd.Next(0,Rooms.Length));
    }
}