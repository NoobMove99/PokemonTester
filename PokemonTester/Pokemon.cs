using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTester
{
    class Pokemon
    {
        private int level = 1;
        private int hp_base;
        private int attack_base;
        private int defense_base;
        private int specialattack_base;
        private int specialdefense_base;
        private int speed;

        public int HP_Base
        {
            get { return hp_base; }
            set { hp_base = value; }
        }


        public int Attack_base
        {
            get { return attack_base; }
            set { attack_base = value; }
        }


        public int Defense_base
        {
            get { return defense_base; }
            set { defense_base = value; }
        }


        public int SpecialAttack_base
        {
            get { return specialattack_base; }
            set { specialattack_base = value; }
        }


        public int SpecialDefense_base
        {
            get { return specialdefense_base; }
            set { specialdefense_base = value; }
        }


        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string Name
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public int Nummer { get; set; }

        public int Level
        {
            get { return level; }
            private set { level = value; }
        }
        public void VerhoogLevel()
        {
            Level++;
        }
        public void VerhoogLevel(int aantal)
        {
            Level = Level + aantal;
        }
        public int Average
        {
            get
            {
                int average = 0;
                average = HP_Base + Attack_base + Defense_base + SpecialAttack_base + SpecialDefense_base + Speed;
                average = average / 6;
                return average;
            }

        }
        public int Total
        {
            get
            {
                return (HP_Base + Attack_base + Defense_base + SpecialAttack_base + SpecialDefense_base + Speed);
            }
        }
        public int HP_Full
        {
            get
            {
                return (((HP_Base + 50) * level) / 50) + 10;
            }
        }
        public int Attack_Full
        {
            get
            {
                return ((Attack_base * Level) / 50) + 5;
            }
        }
        public int Defense_Full
        {
            get
            {
                return ((Defense_base * Level) / 50) + 5;
            }
        }
        public int Speed_Full
        {
            get
            {
                return ((Speed * Level) / 50) + 5;
            }
        }
        public int SpecialDefense_Full
        {
            get
            {
                return ((SpecialDefense_base * Level) / 50) + 5;
            }
        }
        public int SpecialAttack_Full
        {
            get
            {
                return ((SpecialAttack_base * Level) / 50) + 5;
            }
        }
        public void LevelUpTester(int ingegevenlevel)
        {
            Level = ingegevenlevel;
            Console.WriteLine(Name + " Stats: " + HP_Full + ", " + Attack_Full + ", " + Defense_Full + ", " + SpecialAttack_Full + ", " + SpecialDefense_Full + ", " + Speed_Full);
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name + "  (level " + Level + ")");
            Console.WriteLine("Base Stats:");
            Console.WriteLine("     *Health = " + HP_Base);
            Console.WriteLine("     *Speed = " + Speed);
            Console.WriteLine("     *Attack = " + Attack_base);
            Console.WriteLine("     *Defense = " + Defense_base);
            Console.WriteLine("     *Special Attack = " + SpecialAttack_base);
            Console.WriteLine("     *Special Defense = " + SpecialDefense_base);
            Console.WriteLine("Full stats: ");
            Console.WriteLine("     *Health = " + HP_Full);
            Console.WriteLine("     *Speed = " + Speed_Full);
            Console.WriteLine("     *Attack = " + Attack_Full);
            Console.WriteLine("     *Defense = " + Defense_Full);
            Console.WriteLine("     *Special Attack = " + SpecialAttack_Full);
            Console.WriteLine("     *Special Defense = " + SpecialDefense_Full);
        }
    }
}
