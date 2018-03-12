using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            string currentHealthString = new String('|', health);
            string maximumHealthString = new String('.', healthMax - health);
            string currentEnergyString = new String('|', energy);
            string maximumEnergyString = new String('.', energyMax - energy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{currentHealthString}{maximumHealthString}|");
            Console.WriteLine($"Energy: |{currentEnergyString}{maximumEnergyString}|");
            
        }

    }
}
