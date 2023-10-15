public interface IFactory
{
    ObjectPool.EPoolType ObjectType { get; }

    Object CreateInstance();
}