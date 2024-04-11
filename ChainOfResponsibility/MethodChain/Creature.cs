using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodChain
{
    public class Creature
    {
        public string Name;
        public int Defense, Attack;

        public Creature(string name, int defense, int attack)
        {
            Name = name;
            Defense = defense;
            Attack = attack;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Defense: {Defense}, Attack: {Attack}";
        }
    }
}
