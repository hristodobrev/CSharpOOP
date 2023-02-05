using Exercise1.Shields;
using Exercise1.Weapons;

namespace Exercise1.Heroes
{
    internal class BasicHero : Hero
    {
        public BasicHero(string name, int health, Weapon weapon, Shield shield) : base(name, health, weapon, shield)
        {
        }

        public override void Attack(Hero hero)
        {
            hero.Defense(this.Weapon.Damage);
        }
    }
}
