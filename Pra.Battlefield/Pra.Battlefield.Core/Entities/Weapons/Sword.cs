using Pra.Battlefield.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Battlefield.Core.Entities.Weapons
{
    public class Sword:IWeapon
    {

        public bool isSword { get; } = true;

        public void DoDamage(IPlayer player)
        {
            int damage = 3;
            if (player.IsAlive)
            {
                player.TakeDamage(damage);
            }

        }
    }
}
