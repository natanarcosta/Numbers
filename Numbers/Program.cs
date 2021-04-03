using System;
using System.Globalization;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //test commit
        }

        static void FindPiToTheNthDigit()
        {
            //Find PI to the Nth Digit - Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.

            Console.Write("Nth Digit (between 1 and 15 ) of Pi to look for: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0 && n <= 15)
            {
                Console.Write(Math.PI.ToString($"F{n}"));
            } else
            {
                Console.WriteLine("Invalid Number! Number must be an intenger between 1 and 15");
                FindPiToTheNthDigit();
            }     
        }
        static void FibonnaciSequence()
        {
            //Fibonacci Sequence - Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.

            Console.Write("Generate sequence until position: ");
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            sequence[0] = 0;
            sequence[1] = 1;

            for(int i = 2; i < n; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            }
            
            foreach(int x in sequence)
            {
                if(x == sequence.Last())
                {
                    Console.Write(x);
                } else
                {
                    Console.Write(x + ", ");
                }
            }
            

        }
        static void FindFloorCost()
        {
            //Find Cost of Tile to Cover W x H Floor - Calculate the total cost of tile it would take to cover a floor plan of width and height, using a cost entered by the user.

            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double heigth = double.Parse(Console.ReadLine());
            Console.Write("Enter price per square meter: $");
            double price = double.Parse(Console.ReadLine());
            double area = width * heigth;
            double total = price * area;
            Console.WriteLine("Total price: $" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
