using Pra.Battlefield.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Battlefield.Core.Entities.Players
{
    public class SimplePlayer : Player
    {

        private static int number = 0;
        private static Random random = new Random();
      

        //constructor
        public SimplePlayer()
        {
            number++;
            Name=$"Player_{ number}";
        }

       

        public override string ToString()
        {
            return $"{Name} - {Health}";
        }

    }
}
