namespace DataStructSample.OOPSample
{
    internal abstract class Turret
    {
        public enum EBulletType
        {
            Low,
            Mid,
            Hard
        }

        public Character target;

        protected EBulletType bulletType;

        public Turret()
        {
        }

        public abstract float ShootRate { get; }

        public virtual void Shoot(Bullet bullet) =>
            bullet.OnCharacterHit(target);
    }
}