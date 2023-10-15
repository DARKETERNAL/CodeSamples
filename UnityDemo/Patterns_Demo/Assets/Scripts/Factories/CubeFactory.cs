public class CubeFactory : AbstractFactory<CubeObject>
{
    public override ObjectPool.EPoolType ObjectType => ObjectPool.EPoolType.Cube;
}