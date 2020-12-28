using Pra.Battlefield.Core.Entities.Players;
using Pra.Battlefield.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pra.Battlefield.Core.Services
{
    public class SimpleBattlefield : IBattlefield
    {
        public List<IPlayer> Players { get; }
        Random random = new Random();


        public void AddGeneratedPlayer()
        {
            Players.Add(new SimplePlayer());
        }

        public virtual void Attack()
        {
           //List<IPlayer> playersAlive = new List<IPlayer>();
           //foreach(IPlayer player in Players)
           // { if (player.Health>0)
           //     {
           //         playersAlive.Add(player);
           //     }
            
           // }
            foreach (IPlayer player in Players)
            {
                if(player is SimplePlayer)
                {
                    int damage = random.Next(0, 11);
                    player.TakeDamage(damage);
                }
              if(player.Health<0)
                {
                   
                    player.IsAlive = false;
                }
            }

        }
        public int NumberAlive()
        {
            int numberAlive = 0;
            foreach(IPlayer player in Players)
            {
                if(player.Health>0)
                {
                    numberAlive++;
                    
                }
            }
            return numberAlive;
           
        }

        public List<IPlayer> GetAlivePlayers()
        {
            //List<IPlayer> players = new List<IPlayer>();
           
            foreach (IPlayer player in Players)
            {
                if (player.Health > 0 )
                {
                    player.IsAlive = true;
                    Players.Add(player);
                   
                }
                else
                {
                    player.IsAlive = false;
                }

            }
           
            return Players;
        }

        public SimpleBattlefield()
        {
            Players = new List<IPlayer>();
        }
    }
}
