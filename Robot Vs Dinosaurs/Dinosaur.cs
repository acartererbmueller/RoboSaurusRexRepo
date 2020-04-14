using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_Dinosaurs
{


    public class Dinosaur
    {

        //Member Variables (HAS A)
       public string dinosaurType;
        public int levelOfDinosaurHealth;
      public string levelOfDinosaurAttackPower;
       public string levelOfDinosaurEnergy;  

        //Constructor
        public Dinosaur(string dinosaurType, string levelOfDinosaurAttackPower, int levelOfDinosaurHealth, string levelOfDinosaurEnergy)
        {
            //Give the member variables their initial values
            this.dinosaurType = dinosaurType;
            levelOfDinosaurHealth = 100;
            this.levelOfDinosaurAttackPower = levelOfDinosaurAttackPower;
            this.levelOfDinosaurEnergy = levelOfDinosaurEnergy;






        }



        //Member Methods (CAN DO)
        

        //What can a dinosaur do?
        //We need an Attack method

        public void Attack()
        {



        }



    }


}
