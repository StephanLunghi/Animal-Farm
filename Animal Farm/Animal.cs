using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Farm
{


     class Horse
    {
        int health = 50;
        bool isalive = true;

        public Horse()
        {
            if (health <= 0)
            {
                isalive = false;
                Console.WriteLine("Your Horse has died");
            }
        }

        public void Speak()
        {
            Console.WriteLine("Neeeeigh!");
            Console.WriteLine($"Horse health = {health}");
            Console.ReadLine();
        }

        public void Feed()
        {
            Console.WriteLine("The horse is fed");
            health++;
            Console.WriteLine($"Current health = {health}");
            Console.ReadLine();
        }
        public void ShooAway()
        {
            Console.WriteLine("GO ON, get away Horse!!");
            Console.WriteLine("The horse got spooked and ran away");
            Console.WriteLine($"Current health = {health}");
            Console.ReadLine();
        }




    }

    class Dog
    {
        int health = 10;
        bool isalive = true;

        public Dog()
        {
            if (health <= 0)
            {
                isalive = false;
                Console.WriteLine("Your Horse has died");
            }
        }
        public void Speak()
        {
            Console.WriteLine("Bark Bark Bark!");
            Console.WriteLine($"Dog health = {health}");
        }
        public void Feed()
        {
            Console.WriteLine("You have fed the chicken");
            Console.WriteLine("The chicken jumps for joy!");
            health++;
            Console.WriteLine($"Current health = {health}");
        }

    }

    class Cat
    {
        int lives = 9;
        int health = 3;

        public void Speak()
        {
            Console.WriteLine("Meeeeooowwww");
            Console.WriteLine($"Cat lives = {lives}");
            Console.WriteLine($"Cat health = {health}");
        }

        public void Death()
        {
            int death = lives--;

            if (health <= 0)
            {
                Console.WriteLine($"Your cat has died, it has {lives} left.");
            }
            if (lives <= 0)
            {
                Console.WriteLine("Your cat has really died, get the shovel!");
            }
            
        }

        public void ShooAway()
        {
            Console.WriteLine("Scat, get away cat!");
            Console.WriteLine("The cat scurried away");
            health--;
        }

        public void Feed()
        {
            Console.WriteLine("You have fed the cat");
            Console.WriteLine("The cat continues to follow you");
            health++;
        }
    }

    class Chicken
    {
        int health = 5;
        bool isalive = true;
        public Chicken()
        {
            if (health <= 0)
            {
                isalive = false;
                Console.WriteLine("Your Horse has died");
            }
        }
            public void Speak()
        {
            Console.WriteLine("cluck cluck cluck cluck");
            Console.WriteLine($"Chicken health = {health}");
        }
        public void Feed()
        {
            Console.WriteLine("You have fed the chicken");
            Console.WriteLine("The chicken jumps for joy!");
            health++;
            Console.WriteLine($"Current health = {health}");
        }
    }
}
