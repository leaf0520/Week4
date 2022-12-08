using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour { }
   namespace ClassSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Class Selection Program!");
            Console.WriteLine("Please select your class:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Rogue");

            int playerClass = int.Parse(Console.ReadLine());
            int playerHealth = 100;

            switch (playerClass)
            {
                case 1:
                    Console.WriteLine("You have selected the Warrior class!");
                    Console.WriteLine("The Warrior class has the ability to do an extra attack!");
                    break;
                case 2:
                    Console.WriteLine("You have selected the Mage class!");
                    Console.WriteLine("The Mage class has the ability to cast a powerful spell!");
                    break;
                case 3:
                    Console.WriteLine("You have selected the Rogue class!");
                    Console.WriteLine("The Rogue class has the ability to evade enemy attacks!");
                    break;
            }

            while (playerHealth > 0)
            {
                //play the game
                Console.WriteLine("Your health is currently at " + playerHealth);
                Console.WriteLine("Press any key to continue playing...");
                Console.ReadKey();

                //reduce health
                playerHealth -= 10;
            }

            //health has reached 0, reset to class selection screen
            Console.WriteLine("Your health has reached 0. Please select your class again.");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Rogue");

            playerClass = int.Parse(Console.ReadLine());
            playerHealth = 100;

            switch (playerClass)
            {
                case 1:
                    Console.WriteLine("You have selected the Warrior class!");
                    Console.WriteLine("The Warrior class has the ability to do an extra attack!");
                    break;
                case 2:
                    Console.WriteLine("You have selected the Mage class!");
                    Console.WriteLine("The Mage class has the ability to cast a powerful spell!");
                    break;
                case 3:
                    Console.WriteLine("You have selected the Rogue class!");
                    Console.WriteLine("The Rogue class has the ability to evade enemy attacks!");
                    break;
            }
        }
    }
}

