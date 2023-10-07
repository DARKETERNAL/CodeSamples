namespace DataStructSample.OOPSample
{
    internal struct Bullet
    {
        private Turret.EBulletType bulletType;

        public Bullet(Turret.EBulletType bulletType)
        {
            this.bulletType = bulletType;
        }

        public void OnCharacterHit(Character character)
            => character?.ApplyDamage(bulletType);
    }
}