public interface ISpawnable
{
    AbstractObjectPool<Object> Pool { get; set; }

    void Reset(bool activate);

    void Recycle();
}