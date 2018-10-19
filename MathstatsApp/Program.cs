using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathstatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> ints = new List<int>();
            double mu = 0, sigma = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Input numbers\n" +
                    "2 - Calculate the mean\n" +
                    "3 - Calculate the variance\n" +
                    "4 - Calculate the standart deviation\n" +
                    "ESC - Exit");

                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.Escape)
                    break;
                switch (keyinfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        ints.Clear();
                        Console.Write($"Enter numbers separated by commas or spaces - ");
                        string k = Console.ReadLine();
                        foreach (var item in k.Split(new char[] { ' ', ',' }))
                            if (int.TryParse(item, out int n))
                                ints.Add(Convert.ToInt32(n));
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        if (ints.Count == 0)
                        {
                            Console.WriteLine("Set of numbers is empty");
                            break;
                        }
                        mu = 0;
                        foreach (var item in ints)
                            mu += item;
                        Console.WriteLine($"Mean is equals to  {mu = Math.Round(mu / ints.Count, 4)}");
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        if (ints.Count == 0)
                        {
                            Console.WriteLine("Set of numbers is empty");
                            break;
                        }
                        sigma = 0;
                        if (mu == 0)
                        {
                            foreach (var item in ints)
                                mu += item;
                            mu = Math.Round(mu / ints.Count, 4);
                        }
                        foreach (var item in ints)
                            sigma += Math.Pow(item - mu, 2);
                        Console.WriteLine($"Variance is equals to {sigma = Math.Round(sigma / ints.Count, 4)}");
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        if (ints.Count == 0)
                        {
                            Console.WriteLine("Set of numbers is empty");
                            break;
                        }
                        if (mu == 0)
                        {
                            foreach (var item in ints)
                                mu += item;
                            mu = Math.Round(mu / ints.Count, 4);
                        }
                        if (sigma == 0)
                        {
                            foreach (var item in ints)
                                sigma += Math.Pow(item - mu, 2);
                            sigma = Math.Round(sigma / ints.Count, 4);
                        }
                        Console.WriteLine( $"Standard deviation is equals to {Math.Round(Math.Sqrt(sigma),4)}");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
