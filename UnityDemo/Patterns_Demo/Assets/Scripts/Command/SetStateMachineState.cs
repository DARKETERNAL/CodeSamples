public class SetStateMachineState : ICommand
{
    private BaseStateMachine stateMachine;
    private int stateIndex;

    public SetStateMachineState(BaseStateMachine stateMachine, int stateIndex)
    {
        this.stateMachine = stateMachine;
        this.stateIndex = stateIndex;
    }

    public void Execute()
    {
        stateMachine?.ChangeState(stateIndex);
    }
}