using Pra.Battlefield.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Battlefield.Core.Entities.Weapons
{
    public class Pistol : IWeapon

    {
     private static Random random = new Random();
        public bool isPistol { get; } = true;


        public void DoDamage(IPlayer player)
        {
            int damage = random.Next(0, 2);
            if(player.IsAlive)
            {
                player.TakeDamage(damage);
            }
            
        }
    }
}
