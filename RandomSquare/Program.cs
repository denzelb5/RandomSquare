using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomNumbers = new List<double>();
            var squares = new List<double>();
            for (int i = 0; i < 51; i++)
            {
                randomNumbers.Add(random.Next(51));
                var squared = randomNumbers[i] * randomNumbers[i];
                Console.WriteLine("squared " + squared);
                squares.Add(squared);

            }

            var evens = (from n in randomNumbers where (n % 2 == 0) select n);
            foreach (var n in evens)
            {
                Console.WriteLine("Evens " + n);
            }

          
        }
    }
}
