using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PokemonTester
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratePokemon();
            Pokemon pokemon1 = GeneratorPokemon();
            Pokemon pokemon2 = GeneratorPokemon();
            pokemon1.ShowInfo();
            pokemon2.ShowInfo();
            Battle(pokemon1, pokemon2);
            Console.ReadLine();
        }
        static Pokemon GeneratePokemon()
        {
            Pokemon poke = new Pokemon();
            Console.WriteLine("Geef de naam van je favoriete pokemon in: ");
            poke.Name = Console.ReadLine();
            Console.WriteLine("Geef nu het type van deze pokemon in: ");
            poke.Type = Console.ReadLine();
            Console.WriteLine("Geef nu de nummer van de pokemon in: ");
            poke.Nummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base HP in: ");
            poke.HP_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base Attack in: ");
            poke.Attack_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base Defense in: ");
            poke.Defense_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base Special Attack in: ");
            poke.SpecialAttack_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base Special Defense in: ");
            poke.SpecialDefense_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("En als laatste nog de base Speed: ");
            poke.Speed = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Tot welk lvl moet de pokemon geleveled worden?");
            int lvl = Convert.ToInt32(Console.ReadLine());
            poke.LevelUpTester(lvl);
            System.Threading.Thread.Sleep(500);
            poke.ShowInfo();
            return poke;
        }
        static Pokemon GeneratorPokemon()
        {
            Random R = new Random();
            Pokemon poke = new Pokemon();
            poke.HP_Base = R.Next(1, 20);
            poke.Attack_base = R.Next(20, 100);
            poke.Defense_base = R.Next(20, 100);
            poke.SpecialAttack_base = R.Next(20, 150);
            poke.SpecialDefense_base = R.Next(20, 150);
            poke.Speed = R.Next(10, 100);
            return poke;
        }
        static int Battle(Pokemon poke1, Pokemon poke2)
        {
            if (poke1 == null || poke2 == null)
            {
                Console.WriteLine("Een of beide van de pokemon bestaat niet. Het programma zal nu afsluiten...");
                System.Threading.Thread.Sleep(500);
                Environment.Exit(0);
            }
            int Full_Poke1 = poke1.Total;
            int Full_Poke2 = poke2.Total;
            if (Full_Poke1<Full_Poke2)
            {
                Console.WriteLine(poke2.Name + " wint de battle!");
                poke2.VerhoogLevel();
                return 1;
            }
            if (Full_Poke1 > Full_Poke2)
            {
                Console.WriteLine(poke1.Name + " wint de battle!");
                poke1.VerhoogLevel();
                return 1;
            }
            if (Full_Poke1 == Full_Poke2)
            {
                Console.WriteLine("Niemand wint (gelijkspel)");
                return 0;
            }
            else
            {
                return 0;
            }
        }
    }
}
