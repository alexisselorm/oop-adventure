namespace OOPAdventure;

public abstract class Action {
    public virtual string Name => "";

    public virtual void Execute(){
        throw new NotImplementedException();
    }

}