using Pra.Battlefield.Core.Entities.Players;
using Pra.Battlefield.Core.Entities.Weapons;
using Pra.Battlefield.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;



namespace Pra.Battlefield.Core.Services

{

    public class AdvancedBattlefield:IBattlefield
    {
        public List<IPlayer> Players { get; }
        
       private static Random random = new Random();
       public  Bazooka Bazooka { get; set; }
        public Pistol Pistol { get; set; }
        public Sword Sword { get; set; }

        public void AddGeneratedPlayer()
        {
            Players.Add(new WeaponisedPlayer());
        }

        public void Attack()
        {
            List<IPlayer> playersAlive = new List<IPlayer>();
            foreach (IPlayer player in Players)
            {
                if (player.Health > 0)
                {
                    playersAlive.Add(player);
                }

            }

            foreach (IPlayer player in playersAlive)
            {


                if (player is WeaponisedPlayer )
                {
                    
                    int damage = random.Next(50, 101);
                    player.TakeDamage(damage);
                }
              
                if (player.Health <= 0)
                {

                    player.IsAlive = false;                    
                }



            }

        }
        public int NumberAlive()
        {
            int numberAlive = 0;
            int numberDefeated = 0;
            int totalplayers = 0;
            foreach (IPlayer player in Players)
            {
                if (player.Health > 0)
                {
                    numberAlive++;

                }
                if (player.Health == 0)
                {
                    numberDefeated++;
                }
            }
            totalplayers = numberAlive + numberDefeated;
            return totalplayers - numberDefeated;

        }

        public List<IPlayer> GetAlivePlayers()
        {
            //List<IPlayer> players = new List<IPlayer>();

            foreach (IPlayer player in Players)
            {
                if (player.Health > 0)
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

       

        public AdvancedBattlefield()
        {
            Players = new List<IPlayer>();
        }
    }
}

