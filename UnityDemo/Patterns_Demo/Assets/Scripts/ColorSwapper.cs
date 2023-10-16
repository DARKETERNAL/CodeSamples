using System.Collections.Generic;
using UnityEngine;

public class ColorSwapper : MonoBehaviour
{
    protected BaseStateMachine stateMachine;

    private ICommand redStateCommand, greenStateCommand;

    // Start is called before the first frame update
    private void Start()
    {
        List<Material> materials = new List<Material>();
        GetComponent<Renderer>().GetMaterials(materials);

        IState[] states = { new RedState(Color.red, materials[0]), new GreenState(Color.green, materials[0]) };
        SetStateMachine(states);
    }

    protected virtual void SetStateMachine(IState[] states)
    {
        stateMachine = new ColorSwapStateMachine(states);

        redStateCommand = new SetStateMachineState(stateMachine, 0);
        greenStateCommand = new SetStateMachineState(stateMachine, 1);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeToRed();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeToGreen();
        }
    }

    protected virtual void ChangeToGreen()
    {
        greenStateCommand?.Execute();
    }

    protected virtual void ChangeToRed()
    {
        redStateCommand?.Execute();
    }
}