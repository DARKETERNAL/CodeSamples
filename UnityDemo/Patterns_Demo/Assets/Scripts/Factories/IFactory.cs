public interface IFactory<T>
    where T : Object
{
    T CreateInstance();

    ObjectPool.EPoolType ObjectType { get; }
}