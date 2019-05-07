using System;

namespace App
{
    class PositionalAndPropertyPatterns
    {
        public void PositionalPatterns()
        {
            IWeapon weapon = new Sword("Excalibur", 100, 100);

            if (weapon is Sword(var name1, 50, _))
            {
                Console.WriteLine($"{name1} is crap");
            }

            if (weapon is Sword(var name2, 100, _))
            {
                Console.WriteLine($"{name2} is perfect");
            }
        }

        public void PropertyPatterns()
        {
            IWeapon weapon = new Bow("Fail-not", 100, 100);

            if (weapon is Bow { Damage: 50, Name: var name1})
            {
                Console.WriteLine($"{name1} is crap");
            }

            if (weapon is Bow { Damage: 100, Name: var name2 })
            {
                Console.WriteLine($"{name2} is perfect");
            }
        }
    }

    class Sword : Weapon
    {
        public Sword(string name, int damage, int durability) : base(name, damage, durability)
        {
        }

        public void Deconstruct(out string name, out int damage, out int durability)
        {
            name = Name;
            damage = Damage;
            durability = Durability;
        }
    }

    class Bow : Weapon
    {
        public Bow(string name, int damage, int durability) : base(name, damage, durability)
        {
        }
    }

    class Weapon : IWeapon
    {
        public string Name { get; }

        public int Damage { get; }

        public int Durability { get; }

        public Weapon(string name, int damage, int durability)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
        }
    }
    
    internal interface IWeapon
    {
        string Name { get; }

        int Damage { get; }

        int Durability { get; }
    }
}
