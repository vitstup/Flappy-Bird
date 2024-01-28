using Zenject;

public abstract class GameState
{
    [Inject] protected GameStatesManager gameManager;

    public virtual void OnEntered() { }

    public virtual void OnExited() { }

    public virtual bool CanControll() => false;
}