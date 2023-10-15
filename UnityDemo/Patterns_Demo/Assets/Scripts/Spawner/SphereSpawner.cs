public class SphereSpawner : AbstractSpawner<SphereObject>
{
    protected override ObjectPool.EPoolType PoolType => ObjectPool.EPoolType.Sphere;

    private void Awake()
    {
        spawnFrequency = 0.5F;
    }

    protected override void Start()
    {        
        base.Start();
    }
}