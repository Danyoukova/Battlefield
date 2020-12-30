using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Battlefield.Core.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }
        int Health { get;  }
        bool IsAlive { get; set; }

        void TakeDamage(int damage);
        void Attack(IPlayer otherPlayer);
    }
}
