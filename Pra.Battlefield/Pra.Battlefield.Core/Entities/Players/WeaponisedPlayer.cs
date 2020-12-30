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

    public enum IWeapon { Bazooka, Pistol, Sword}

    public class WeaponisedPlayer : Player
    {
        private static Random random = new Random();

        public WeaponisedName WName { get;  }
        public IWeapon Weapon { get; set; }

       public override int Health
        {
            get { return health; }
            set
            {
                
                if (value <= 0) health =0;
                else health = value;
            }
        }

        public WeaponisedPlayer()
        {
           WName= (WeaponisedName)random.Next(0, Enum.GetValues(typeof(WeaponisedName)).Length);

           Weapon = (IWeapon)random.Next(0, Enum.GetValues(typeof(IWeapon)).Length);
         
           Name = $"{WName}({Weapon})";             

        }


        public override string ToString()
        {
            return $"{Name} -{Health}";
        }







    }
}
