using UnityEngine;

public delegate void OnColorChange(int stateIndex);

public delegate void OnRequestAnimation(bool animate);

public class ObserverColorSwapper : ColorSwapper
{
    public static ObserverColorSwapper Instance { get; private set; }

    public OnColorChange onColorChange;
    public OnRequestAnimation onRequestAnimation;

    private bool isAnimating;

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

    protected override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleAnimation();
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

    private void ToggleAnimation()
    {
        if (onRequestAnimation != null)
        {
            isAnimating = !isAnimating;
            onRequestAnimation(isAnimating);
        }
    }
}