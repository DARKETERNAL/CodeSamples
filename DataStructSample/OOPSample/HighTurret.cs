namespace DataStructSample.OOPSample
{
    internal class HighTurret : Turret
    {
        public HighTurret() : base()
        {
            bulletType = EBulletType.Hard;
        }

        public override float ShootRate
        {
            get => 0.5F;
        }

        public override void Shoot(Bullet bullet)
        {
            Console.WriteLine("Shooting with high bullet");
            base.Shoot(bullet);
        }
    }
}