using Pra.Battlefield.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Battlefield.Core.Entities.Weapons
{
    public class Bazooka : IWeapon
    {
       private static Random random = new Random();

        public bool isBazooka { get; }
       

        private bool IsCharged()
        {
            int trueorfalse = random.Next(2);
            return Convert.ToBoolean(trueorfalse);
        }

        public void DoDamage(IPlayer player)
        {
            int damage = random.Next(50, 100);
            if (player.IsAlive)
            {
                player.TakeDamage(damage);
            }

        }


    }
}
