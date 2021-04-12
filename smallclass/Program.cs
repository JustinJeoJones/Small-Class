using System;

namespace smallclass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Sean", "Kalai", "Jean", "Justin", "Alice", "Jason", "Kristen"};
            string[] cities = { "Plymouth", "Troy", "Lascahobas", "Wyoming", "Detroit", "Courtright", "Orange Park"};

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Name: {names[i]}\tCity: {cities[i]}");
            }
        }
    }
}
