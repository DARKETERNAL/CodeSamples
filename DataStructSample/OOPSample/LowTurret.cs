namespace DataStructSample.OOPSample
{
    internal class LowTurret : Turret
    {
        public LowTurret() : base()
        {
            bulletType = EBulletType.Low;
        }

        public override float ShootRate { get => 1.0F; }

        //public override void Shoot(Bullet bullet)
        //{
        //    base.Shoot(bullet);
        //    Console.WriteLine("Shooting with low bullet");
        //}
    }
}