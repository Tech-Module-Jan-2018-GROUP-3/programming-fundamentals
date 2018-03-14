// CONFIRMED from TsvetanaHarizanova
using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            // So we need to make character stats for user

            // We receive name from the Console -> a string;
            string characterName = Console.ReadLine();
            /* We also receive 
             Current Health -> an integer
             Maximum Health -> an integer
             Current Energy -> an integer
             Maximum Energy -> an integer
             */
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            // Before we print them we'll make the values of health and energy in a string so we'll print the output easily
            string currentHealthString = new String('|', currentHealth);
            string maximumHealthString = new String('.', maxHealth - currentHealth);
            string currentEnergyString = new String('|', currentEnergy);
            string maximumEnergyString = new String('.', maxEnergy - currentEnergy);

            // Printing the name
            Console.WriteLine($"Name: {characterName}");
            // Printing the health bar
            Console.WriteLine($"Health: |{currentHealthString}{maximumHealthString}|");
            // Printing the energy bar
            Console.WriteLine($"Energy: |{currentEnergyString}{maximumEnergyString}|");
        }
    }
}
