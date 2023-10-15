public class SphereFactory : AbstractFactory<SphereObject>
{
    public override ObjectPool.EPoolType ObjectType => ObjectPool.EPoolType.Sphere;
}