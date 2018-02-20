using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceClassStats
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int [,] Zumba = { { 12, 10, 17, 22, 0, 0 }, { 11, 13, 17, 22, 0, 0 }, { 12, 10, 22, 22, 0, 0 }, { 9, 14, 17, 22, 0, 0 }, { 12, 10, 21, 12, 0, 0 }, { 12, 10, 5, 10, 0, 0 } };
            int [,] Spinning = {{7,11,15,8,0,0},{9,9,9,9,0,0},{3,12,13,7,0,0},{2,9,9,10,0,0},{8,4,9,4,0,0},{4,5,9,4,0,0}};
            ZumbaCalc(Zumba);
            ZumbaOutput(Zumba);
            SpinningCalc(Spinning);
            SpinningOutput(Spinning);
            Console.Read();
        }
       
        
        
        static void ZumbaCalc(int[,]Zumba)
        {
            int i; 
            for (i = 0; i < 6; i++)
            {
                Zumba[i, 4] = Zumba[i, 0] + Zumba[i, 1] + Zumba[i, 2] + Zumba[i, 3];
            }
            for (i = 0; i < 6; i++)
            {
                Zumba[i, 5] = Zumba[i, 4] * 4;
            }
        }
        static void ZumbaOutput(int[,] Zumba)
        {
            int i;
            int totalprofit = 0;
            Console.WriteLine("Number of Customers at Zumba Class at 1, 3, 5, and 7. Then the totals and revenues for each day(Row 1 is Monday, Row 6 is Saturday)");
            for (i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0}  ", Zumba[i, j]);
                }
                Console.WriteLine();
            }
            for (i = 0; i < 6; i++)
            {
                totalprofit += Zumba[i, 5];
            }
            Console.WriteLine("Total Profit from Zumba (Sum of left column) = {0:C}", totalprofit);
        }
        static void SpinningCalc(int[,] Spinning)
        {
            int i;
            for (i = 0; i < 6; i++)
            {
                Spinning[i, 4] = Spinning[i, 0] + Spinning[i, 1] + Spinning[i, 2] + Spinning[i, 3];
            }
            for (i = 0; i < 6; i++)
            {
                Spinning[i, 5] = Spinning[i, 4] * 5;
            }
        }
        static void SpinningOutput(int[,] Spinning)
        {
            int i;
            int totalprofit = 0;
            Console.WriteLine("Number of Customers at Spinning Class at 2, 4, 6, and 8. Then the totals and revenues for each day(Row 1 is Monday, Row 6 is Saturday)");
            for (i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0}  ", Spinning[i, j]);
                }
                Console.WriteLine();
            }
            for (i = 0; i < 6; i++)
            {
                totalprofit += Spinning[i, 5];
            }
            Console.Write("Total Profit from Spinning Class (Sum of left column) = {0:C}", totalprofit);
        }

    }
}

