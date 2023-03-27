namespace OOPAdventure;

public abstract class Action {
    public virtual string Name => "";

    public virtual void Execute(string[] args){
        throw new NotImplementedException();
    }

}