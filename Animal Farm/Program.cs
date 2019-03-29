using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Farm
{
     class Program
    {
        static void Main(string[] args)
        {
            Dialogue dialogue = new Dialogue();
            UserActions useractions = new UserActions();

            

            var horse = new Horse();
            var chicken = new Chicken();
            var dog = new Dog();
            var cat = new Cat();

            //intialize your animals   CHECK 
            dialogue.IntroDialogue();
            //application loop
            do
            {
                
                useractions.ChooseAnimals();
                //display messages
                //ask for user input
                //action the user input

            } while (true);


           //Horse horse = new Horse();
           // Cat cat = new Cat();
           // horse.Speak();
           // cat.Death();
           // cat.Death();

            

        }
    }
}
