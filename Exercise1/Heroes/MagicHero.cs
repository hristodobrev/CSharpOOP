using Exercise1.Shields;
using Exercise1.Weapons;

namespace Exercise1.Heroes
{
    internal class MagicHero : Hero
    {
        public MagicHero(string name, int health, Weapon weapon, Shield shield) : base(name, health, weapon, shield)
        {
        }

        public override void Attack(Hero hero)
        {
            hero.Defense(this.Weapon.Damage);

            Random random = new Random();
            if (random.Next(1, 6) == 1)
            {
                hero.Defense(this.Weapon.Damage);
            }
        }
    }
}
