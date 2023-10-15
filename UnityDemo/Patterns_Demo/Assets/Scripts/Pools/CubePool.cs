public class CubePool : AbstractObjectPool<CubeObject>
{
    public override ObjectPool.EPoolType PoolType => ObjectPool.EPoolType.Cube;
}