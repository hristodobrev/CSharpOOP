using Exercise1.Heroes;

namespace Exercise1.Core
{
    public class Engine
    {
        private Hero hero1;
        private Hero hero2;
        private bool hero1Turn = true;

        public Engine(Hero hero1, Hero hero2)
        {
            this.hero1 = hero1;
            this.hero2 = hero2;
        }

        public void Run()
        {
            Console.WriteLine($"Duel: {this.hero1} vs {this.hero2}");

            while (hero1.Health > 0 && hero2.Health > 0)
            {
                if (hero1Turn)
                {
                    hero1.Attack(hero2);
                    Console.WriteLine(hero2);
                }
                else
                {
                    hero2.Attack(hero1);
                    Console.WriteLine(hero1);
                }

                hero1Turn = !hero1Turn;
            }

            this.PrintWinner();
        }

        private void PrintWinner()
        {
            if (hero1.Health > 0)
            {
                Console.WriteLine($"{hero1.Name} is winner!");
            }
            else
            {
                Console.WriteLine($"{hero2.Name} is winner!");
            }
        }
    }
}
