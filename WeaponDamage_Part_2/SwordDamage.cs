﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponDamage_Part_2
{
    class SwordDamage : WeaponDamage
    {
        private const int BASE_DAMAGE = 3; 
        private const int FLAME_DAMAGE = 2;

        public SwordDamage(int startingRoll) : base(startingRoll) { }
        
        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;

            if (Magic)
            {
                magicMultiplier = 1.75M;
            }

            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

            if (Flaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }
    }
}
