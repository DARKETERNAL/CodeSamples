public class CubeSpawner : AbstractSpawner<CubeObject>
{
    protected override ObjectPool.EPoolType PoolType => ObjectPool.EPoolType.Cube;
}