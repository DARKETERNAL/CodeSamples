using UnityEngine;

public class ObjectFactory : AbstractFactory<Object>
{
    [SerializeField]
    private ObjectPool.EPoolType objectType = ObjectPool.EPoolType.None;

    public override ObjectPool.EPoolType ObjectType => objectType;
}