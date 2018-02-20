using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandNumWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //All methods were written by Connor Clements
            int i;
            int number;
            int max = 0;
            int min = 100000;
            int odd = 0;
            Random rnd = new Random();

            for (i = 1; i <= 1000; i++)
            {
                number = rnd.Next(0, 100000);
                if (number > max)
                {
                    max = number;
                }
                else if (number < min)
                {
                    min = number;
                }
                if ((number % 2) != 0)
                {
                    odd++;
                    //Console.Write(odd);
                }
            }
            Console.WriteLine("Problem 1\nThe max was: {0}\nThe min was: {1}\nNumber of odd numbers: {2}", max, min, odd);
            Console.WriteLine("\nProblem 2");

            string i_string;
            double input = 0;
            double total = 0;
            double taxpercentage = .0775;
            double tax_value;
            double shipping = 0;
            int items = 0;
            while (input != -1)
            {
                if (items == 0)
                {
                    Console.WriteLine("Enter the price of the first item, enter a value of -1 when finished: ");
                    i_string = Console.ReadLine();
                    input = Convert.ToInt32(i_string);
                }
                else
                {
                    Console.WriteLine("Enter the price of the next item, enter a value of -1 when finished: ");
                    i_string = Console.ReadLine();
                    input = Convert.ToInt32(i_string);
                }
                
                total += input;
                items++;
            }
            items--;
            tax_value = total * taxpercentage;
            if (total < 100)
            {
                if (items < 3)
                {
                    shipping = 3.5;
                }
                else if (items < 7)
                {
                    shipping = 5;
                }
                else if (items < 11)
                {
                    shipping = 7;
                }
                else if (items < 16)
                {
                    shipping = 9;
                }
                else
                {
                    shipping = 10;
                }
            }
            Console.WriteLine("Purchase charge: {0:C}", total);
            Console.WriteLine("Number of items: {0}", items);
            Console.WriteLine("Sales tax: {0:C}", tax_value);
            Console.WriteLine("Shipping charge: {0:C}", shipping);
            Console.WriteLine("Total charge: {0:C}", total + tax_value + shipping);
            Console.Read();



        }
    }
}
