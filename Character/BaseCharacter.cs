using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelgeronDungeons.Character
{
    class BaseCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int ArmourClass { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public BaseCharacter (string name, int health, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int armourClass)
        {
            Name = name;
            Health = health;
            ArmourClass = armourClass;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }
    }
}
