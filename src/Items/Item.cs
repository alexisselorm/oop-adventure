namespace OOPAdventure;

public abstract class Item {

    public virtual string? Name {get; set; }

    public bool SingleUse {get; set; }
    public bool canTake {get; set; }=true;
    public virtual void Use(string name){
        throw new NotImplementedException();
    }
}