namespace DataStructSample.OOPSample
{
    internal class Character
    {
        public Character(int hp)
        {
            HP = hp;
        }

        public int HP { get; private set; }

        public void ApplyDamage(Turret.EBulletType bulletType)
        {
            int damage = 0;

            switch (bulletType)
            {
                case Turret.EBulletType.Low:
                    damage = 1;
                    break;

                case Turret.EBulletType.Mid:
                    damage = 2;
                    break;

                case Turret.EBulletType.Hard:
                    damage = 3;
                    break;
            }

            HP -= damage;

            if (HP < 1)
            {
                // There should be something to destroy this object
            }
        }
    }
}