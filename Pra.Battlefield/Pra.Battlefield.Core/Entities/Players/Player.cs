using Pra.Battlefield.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Battlefield.Core.Entities.Players
{
    public abstract class Player : IPlayer
    {
        public string Name { get;set; }

        public int Health { get; set; } 

        public bool IsAlive { get; set; } = true;
        Random random = new Random();

        public Player()
        {
            Health = 100;
        }

        public void Attack(IPlayer otherPlayer)
        {
            if(otherPlayer.Health>0)
            {
                int damage = random.Next(0, 11);
                otherPlayer.TakeDamage(damage);
            }
            if (Health < 0) Health = 0;
        }

        public void TakeDamage(int damage)
        {
            if(Health>0)
            {
                Health -= damage;
            }
           else
            { Health = 0; }
        }
    }
}
