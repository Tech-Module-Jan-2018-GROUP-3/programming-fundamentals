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

            string rpt1 = new String('|', health);
            string rpt2 = new String('.', healthMax - health);
            string rpt3 = new String('|', energy);
            string rpt4 = new String('.', energyMax - energy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{rpt1}{rpt2}|");
            Console.WriteLine($"Energy: |{rpt3}{rpt4}|");
            
        }

    }
}
