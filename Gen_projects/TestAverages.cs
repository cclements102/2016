using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = { { 87, 96, 70 }, { 68, 87, 90 }, { 94, 100, 90 }, { 100, 81, 82 }, { 83, 65, 85 }, { 78, 87, 65 }, { 85, 75, 83 }, { 91, 94, 100 }, { 76, 72, 84 }, { 87, 93, 73 } };
            int i;
            double total_score;
            double scores = 3;
            Console.WriteLine("             Test 1  Test 2  Test 3  Average");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Student  {0}       {1}     {2}     {3}", i + 1, matrix[i, 0], matrix[i, 1], matrix[i, 2]);
                total_score = (matrix[i, 0] + matrix[i, 1] + matrix[i, 2]);
                Console.WriteLine("     {0,2}", total_score / scores);
            }
            Console.ReadLine();
                

        }
    }
}
