namespace Exercise1.Weapons
{
    public class MagicWeapon : Weapon
    {
        public MagicWeapon()
        {
            this.Damage = 8;
        }

        public override int Damage
        {
            get
            {
                Random random = new Random();
                int rand = random.Next(1, 6);
                if (rand == 1)
                    return base.Damage * 2;

                return base.Damage;
            }
            protected set
            {
                base.Damage = value;
            }
        }
    }
}
