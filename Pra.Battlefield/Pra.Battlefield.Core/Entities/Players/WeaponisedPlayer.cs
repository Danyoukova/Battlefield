using Pra.Battlefield.Core.Entities.Weapons;
using Pra.Battlefield.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Battlefield.Core.Entities.Players
{
       
    public enum WeaponisedName  
        { TomBrady, 
        AaronRodgers, 
        KylerMurray, 
        AaronDonald, 
        EzekielElliott, 
        BenRoethlisberger, 
        SaquonBarkley, 
        DrewBrees, 
        ToddGurley, 
        KhalilMack, 
        PatrickMahomes, 
        JakeRudock }
    

    public class WeaponisedPlayer : Player
    {
        Random random = new Random();

        public WeaponisedName WName { get;  }
        public Bazooka Bazooka { get; set; }
        public Pistol Pistol { get; set; }
        public Sword Sword { get; set; }
        public IWeapon Weapon { get; set; }

        public List<IWeapon> Weapons { get; set; }

        public WeaponisedPlayer()
        {
           WName= (WeaponisedName)random.Next(0, Enum.GetValues(typeof(WeaponisedName)).Length);
           
            Name = $"{WName}({Weapon})"; 

        }


        public override string ToString()
        {
            return $"{WName} ({Weapon})-{Health}";
        }







    }
}
