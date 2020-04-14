using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_Dinosaurs
{
    public class Robot
    {

        //Member Variables (HAS A)
        public string name;
        public int health;
        public string powerLevel;
        public string weaponName;
       public string weaponPowerLevel;

        //Constructor
        public Robot(string name, int health, string powerLevel, string weaponName, string weaponPowerLevel)
        {
            //give the member variables their inital values
            this.name = name;
            health = 100;
            this.powerLevel = powerLevel;
            this.weaponName = weaponName;
            this.weaponPowerLevel = weaponPowerLevel;

            
        }

        //Member Methods (CAN DO)
        //Attack a dino

    }
}
