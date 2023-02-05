namespace Exercise1.Weapons
{
    public abstract class Weapon
    {
        private int damage;

        public virtual int Damage
        {
            get
            {
                Random random = new Random();
                double percentage = (random.Next(8, 13) / 10.0);

                return (int)(this.damage * percentage);
            }
            protected set
            {
                this.damage = value;
            }
        }
    }
}
