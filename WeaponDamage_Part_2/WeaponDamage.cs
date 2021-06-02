using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDamage_Part_2
{
    class WeaponDamage
    {
        private int roll;
        private bool flaming;
        private bool magic;

        public WeaponDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }

        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value; CalculateDamage();
            }
        }

        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value; CalculateDamage();
            }
        }

        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value; CalculateDamage();
            }

        }

        public int Damage { get; protected set; }

        protected virtual void CalculateDamage()
        {
            Console.WriteLine("Never called");
        }

    }
}
