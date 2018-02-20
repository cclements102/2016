using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            int days;
            double min;
            double max;
            double ave;
            double avexlo;
            string range;
            double[] tempsc = new double[7];
            temp = gettemp();
            double[] temps = new double[] { 64, 72, 76, 78, 53, 48, 68 };
            days = tempseval(temps, temp);
            Console.WriteLine("Number of days below {0}: {1}", temp, days);
            min = getmin(temps);
            max = getmax(temps);
            ave = getave(temps);
            avexlo = getavexlo(temps, min);
            outdata(min, max, ave, avexlo);
            range = (max - min).ToString();
            //celsius(temps, tempsc);

            Console.WriteLine("The range was: " + range);
            Console.Read();
        }
        static double gettemp()
        {
            double temp;
            string tempstr;
            Console.Write("Enter a temperature to compare: ");
            tempstr = Console.ReadLine();
            temp = Convert.ToInt32(tempstr);
            return (temp);
        }
        static int tempseval(double[] temps, double temp)
        {
            int below = 0;
            for (int i = 0; i < 7; i++)
            {
                if (temps[i] < temp)
                {
                    below++;
                }
            }
            return (below);
        }
        static double getmin(double[] temps)
        {
            int i;
            double min = temps[0];
            for (i = 0; i < 7; i++)
            {
                if (temps[i] < min)
                {
                    min = temps[i + 1];
                }
            }
            return (min);
        }
        static double getmax(double[] temps)
        {
            int i;
            double max = temps[0];
            for (i = 0; i < 7; i++)
            {
                if (temps[i] > max)
                {
                    max = temps[i];
                }
            }
            return (max);
        }
        static double getave(double[] temps)
        {
            double total = 0;
            double ave;
            double size = 7;
            int i;
            for (i = 0; i < 7; i++)
            {
                total += temps[i];
            }
            ave = total / size;
            return (ave);
        }
        static double getavexlo(double[] temps, double min)
        {
            double total = 0;
            double size = 6;
            double avexlo;
            int i;
            for (i = 0; i < 7; i++)
            {
                total += temps[i];
            }
            total = total - min;
            avexlo = total / size;
            return (avexlo);
        }
        static void outdata(double min, double max, double ave, double avexlo)
        {
            Console.WriteLine("Min: {0}\nMax: {1}\nAverage: {2}\nAverage excluding lowest: {3}", min, max, ave, avexlo);
            return;
        }
        /*static void celsius(double [] temps, double [] tempsc)
        {
            int i;
            for(i = 0; i < 7; i++)
            {
                tempsc[i] = ((temps[i] - 32) * (5 / 9));
                Console.WriteLine("Fahrenheit
            }*/
            
    }
}
