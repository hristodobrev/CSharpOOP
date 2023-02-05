using Exercise1.Shields;
using Exercise1.Weapons;

namespace Exercise1.Heroes
{
    public abstract class Hero
    {
        public event ReceiveMessage OnReceiveMessage;

        public Hero(string name, int health, Weapon weapon, Shield shield)
        {
            this.Name = name;
            this.Health = health;
            this.Weapon = weapon;
            this.Shield = shield;
        }

        public string Name { get; private set; }
        public int Health { get; private set; }

        public Weapon Weapon { get; private set; }
        public Shield Shield { get; private set; }

        public abstract void Attack(Hero hero);
        public virtual void Defense(int damage)
        {
            int healthToReduce = damage - this.Shield.BlockRate;

            if (healthToReduce > 0)
                this.Health -= healthToReduce;

            if (this.OnReceiveMessage != null)
                this.OnReceiveMessage($"{this.Name} has taken {healthToReduce} damage.");
        }

        public override string ToString()
        {
            return $"({this.GetType().Name}) {this.Name} - {this.Health}HP";
        }
    }
}
