using UnityEngine;

public abstract class BaseColorState : IState
{
    protected Color color { get; set; }
    protected Material material { get; set; }

    public BaseColorState(Color color, Material material)
    {
        this.color = color;
        this.material = material;
    }

    public void Execute()
    {
        material?.SetColor("_Color", color);
    }
}