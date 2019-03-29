using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Farm
{
    class UserActions
    {
        public void ChooseAnimals()
        {
            
            Console.WriteLine("Choose an animal");
            Console.WriteLine("1: Horse");
            Console.WriteLine("2: Dog");
            Console.WriteLine("3: Chicken");
            Console.WriteLine("4: Cat");

            ConsoleKeyInfo action;
            action = Console.ReadKey(true);
            var horse = new Horse();



            switch (action.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                
                    {
                        
                        Console.Clear();
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1: Tell the horse to Speak");
                        Console.WriteLine("2: Feed the horse");
                        Console.WriteLine("3: Shoo the horse away");
                        var value = Console.ReadLine();

                        if (value == "1")
                        {
                            Console.Clear();
                            horse.Speak();
                            
                            
                            
                            
                        }
                        else if (value == "2")
                        {
                            Console.Clear();
                            horse.Feed();
                            
                            
                            
                        }
                        else if (value == "3")
                        {
                            Console.Clear();
                            horse.ShooAway();
                            
                         
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I didn't understand... try again.");
                            Console.ReadLine();
                            Console.Clear();
                            ChooseAnimals();
                        }

                    break;
                    }




            }
            
        }


    }
}
