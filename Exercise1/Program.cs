using Exercise1.Core;
using Exercise1.Exceptions;
using Exercise1.Heroes;
using Exercise1.Shields;
using Exercise1.Weapons;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter weapon1: ");
        Weapon wep1 = GetWeaponFromUser();
        Console.WriteLine("Please enter weapon2: ");
        Weapon wep2 = GetWeaponFromUser();

        Console.WriteLine("Please enter shield1: ");
        Shield shield1 = GetShieldFromUser();
        Console.WriteLine("Please enter shield2: ");
        Shield shield2 = GetShieldFromUser();

        Console.WriteLine("Please enter hero1: ");
        Hero hero1 = GetHeroFromUser(wep1, shield1);
        Console.WriteLine("Please enter hero2: ");
        Hero hero2 = GetHeroFromUser(wep2, shield2);

        hero1.OnReceiveMessage += PrintMessage;
        hero2.OnReceiveMessage += PrintMessage;

        Engine engine = new Engine(hero1, hero2);
        engine.Run();
    }

    private static Weapon GetWeaponFromUser()
    {
        Weapon weapon = null;
        while (weapon == null)
        {
            try
            {
                string line = Console.ReadLine();

                switch (line)
                {
                    case "BasicWeapon":
                        weapon = new BasicWeapon();
                        break;
                    case "MagicWeapon":
                        weapon = new MagicWeapon();
                        break;
                    default:
                        throw new WeaponNotFoundException(line);
                }
            }
            catch (WeaponNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        return weapon;
    }

    private static Shield GetShieldFromUser()
    {
        Shield shield = null;
        while (shield == null)
        {
            try
            {
                string line = Console.ReadLine();

                switch (line)
                {
                    case "BasicShield":
                        shield = new BasicShield();
                        break;
                    case "MagicShield":
                        shield = new MagicShield();
                        break;
                    default:
                        throw new ShieldNotFoundException(line);
                }
            }
            catch (ShieldNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        return shield;
    }

    private static Hero GetHeroFromUser(Weapon weapon, Shield shield)
    {
        Hero hero = null;
        while (hero == null)
        {
            try
            {
                string[] line = Console.ReadLine().Split(' ');
                string name = line[1];
                int health = int.Parse(line[2]);

                switch (line[0])
                {
                    case "BasicHero":
                        hero = new BasicHero(name, health, weapon, shield);
                        break;
                    case "MagicHero":
                        hero = new MagicHero(name, health, weapon, shield);
                        break;
                    default:
                        throw new HeroNotFoundException(line[0]);
                }
            }
            catch (HeroNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter integer for hero health!");
            }
        }

        return hero;
    }

    private static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}