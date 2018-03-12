using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            // So we need to make character stats for user

            // We receive name from the Console -> a string;
            string name = Console.ReadLine();
            /* We also receive 
             Current Health -> an integer
             Maximum Health -> an integer
             Current Energy -> an integer
             Maximum Energy -> an integer
             */
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            // Before we print them we'll make the values of health and energy in a string so we'll print the output easily
            string currentHealthString = new String('|', health);
            string maximumHealthString = new String('.', healthMax - health);
            string currentEnergyString = new String('|', energy);
            string maximumEnergyString = new String('.', energyMax - energy);

            // Printing the name
            Console.WriteLine($"Name: {name}");
            // Printing the health bar
            Console.WriteLine($"Health: |{currentHealthString}{maximumHealthString}|");
            // Printing the energy bar
            Console.WriteLine($"Energy: |{currentEnergyString}{maximumEnergyString}|");
        }
    }
}
