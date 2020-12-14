using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Battlefield.Core.Interfaces
{
    public interface IBattlefield
    {
        List<IPlayer> Players { get; }

        void AddGeneratedPlayer();
        List<IPlayer> GetAlivePlayers();
        void Attack();
    }
}
