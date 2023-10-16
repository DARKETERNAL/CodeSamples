using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private bool registeredToEvents;

    // Start is called before the first frame update
    private void Start()
    {
        RegisterToSwapperEvents();
    }

    private void RegisterToSwapperEvents(bool register = true)
    {
        if (register)
        {
            ObserverColorSwapper.Instance.onRequestAnimation += ToggleAnimation;
        }
        else
        {
            ObserverColorSwapper.Instance.onRequestAnimation -= ToggleAnimation;
        }

        registeredToEvents = register;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RegisterToSwapperEvents(!registeredToEvents);
        }
    }

    private void ToggleAnimation(bool animate)
    {
        animator.SetBool("isAnimating", animate);
    }
}