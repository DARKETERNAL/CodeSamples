public delegate void OnColorChange(int stateIndex);

public class ObserverColorSwapper : ColorSwapper
{
    public static ObserverColorSwapper Instance { get; private set; }

    public OnColorChange onColorChange;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    protected override void SetStateMachine(IState[] states)
    {
        stateMachine = new ObserverColorSwapStateMachine(states);
    }

    protected override void ChangeToGreen()
    {
        onColorChange?.Invoke(1);
    }

    protected override void ChangeToRed()
    {
        onColorChange?.Invoke(0);
    }
}