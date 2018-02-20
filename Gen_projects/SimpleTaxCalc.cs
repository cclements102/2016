using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaxCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programmer: Connor Clements
             * Date: 8/31/15
             * Desc: Calculating commission and deductions from commission for Nesbith Lang
             * */
            string employeeName = "Nesbith Lang";
            double sales = 161432;
            double commission = sales * .07;
            double federal_tax = commission * .18;
            double retirement = commission * .10;
            double social = commission * .06;
            double income = commission - federal_tax - retirement - social;
            Console.WriteLine("Income and Tax information for: {0}", employeeName);
            Console.WriteLine("Sales: {0:c}", sales);
            Console.WriteLine("Commission: {0:c}", commission);
            Console.WriteLine("Federal Tax deduction: {0:c}", federal_tax);
            Console.WriteLine("Retirement fund deduction: {0:c}", retirement);
            Console.WriteLine("Social Security deduction: {0:c}", social);
            Console.WriteLine("Net income: {0:c}", income);
            Console.ReadLine();

        }
    }
}
