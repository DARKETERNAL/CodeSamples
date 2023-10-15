using UnityEngine;

public class ObjectPool : AbstractObjectPool<Object>
{
    public enum EPoolType
    {
        None,
        Cube,
        Sphere
    }

    [SerializeField]
    private EPoolType poolType;

    public override EPoolType PoolType => poolType;
}