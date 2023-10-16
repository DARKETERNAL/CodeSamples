public abstract class BaseStateMachine
{
    private IState[] states;

    private IState currentState;

    public BaseStateMachine(IState[] states, IState currentState = null)
    {
        this.states = states;
        ChangeState(0);
    }

    public void Execute() => currentState?.Execute();

    public void ChangeState(int stateIndex)
    {
        if (stateIndex > -1 && states != null && states.Length > 0 && states.Length > stateIndex)
        {
            IState nextState = states[stateIndex];

            if (currentState != nextState)
            {
                currentState = nextState;
            }

            currentState?.Execute();
        }
    }
}