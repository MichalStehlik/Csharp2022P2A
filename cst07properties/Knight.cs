using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cst07properties
{
    internal class Knight
    {
        private string _name; // atribut (field)
        public int HP { get; private set; }

        public Knight(string name) // constructor
        {
            Name = name;
            HP = 10;
        }
        public Knight(string name, int hp) // constructor
        {
            Name = name;
            HP = hp;
        }

        public string GetName() // metoda (method)
        {
            return _name;
        }

        public string Name // vlastnost (property)
        {
            get { return _name; }
            set { if (value != "Jiří") _name = value; }
        }

        public string Fullname {
            get { return "Sir " + Name; }
        }

        public bool GetHit(int damage)
        {
            if (damage >= 0)
            {
                HP -= damage;
                if (HP < 0) HP = 0; 
            }
            return HP > 0 ? true : false;
        }

        public bool IsAlive { get { return HP > 0; } }

        public void Attack(Knight target, int damage)
        {
            target.GetHit(damage); 
        }
    }
}
