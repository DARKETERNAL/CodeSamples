public class SpherePool : AbstractObjectPool<SphereObject>
{
    public override ObjectPool.EPoolType PoolType => ObjectPool.EPoolType.Sphere;
}