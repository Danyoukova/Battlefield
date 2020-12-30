using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Battlefield.Core.Interfaces
{
    public interface IWeapon
    {
        void DoDamage(IPlayer player);
    }
}
