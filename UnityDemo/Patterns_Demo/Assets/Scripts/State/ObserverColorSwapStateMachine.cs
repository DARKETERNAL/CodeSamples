public class ObserverColorSwapStateMachine : ColorSwapStateMachine
{
    public ObserverColorSwapStateMachine(IState[] states, IState currentState = null) : base(states, currentState)
    {
        ObserverColorSwapper.Instance.onColorChange += ChangeState;
    }
}