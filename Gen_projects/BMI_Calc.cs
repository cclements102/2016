using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calc
{
    class BMI_Calc
    {
        //ALL CLASSES AND METHODS WERE DONE BY CONNOR CLEMENTS
        static void Main(string[] args)
        {
            string username;
            double height = 0;
            double weight;
            double bmi;
            double age;
            double sex;
            double abfp;
            double cbfp;

            getname(out username);
            getheight(ref height);
            age = getage();
            sex = getsex();
            weight = getweight();
            bmi = calc_bmi(height, weight);
            BFP user1 = new BFP(bmi, age, sex);
            abfp = user1.Adultbfpcalc();
            cbfp = user1.Childbfpcalc();
            BFPEval(abfp, sex);
            Console.WriteLine("\n{0}'s BMI", username);
            Console.WriteLine("Height(in.): {0}", height);
            Console.WriteLine("Weight(lbs): {0}", weight);
            Console.WriteLine("BMI: {0}", bmi);
            Console.WriteLine("Body Fat Percentage (adult): {0}", abfp);
            Console.WriteLine("Body Fat Percentage (child): {0}", cbfp);
            BMIBrackets(bmi);
            BFPBrackets(abfp, age, sex);

            Console.Read();
        }
        static void getname(out string username)
        {
            Console.Write("Please enter your name: ");
            username = Console.ReadLine();
        }
        static void getheight(ref double height)
        { 
            string height_string;
            Console.Write("Please enter your height(in.): ");
            height_string = Console.ReadLine();
            height = Convert.ToDouble(height_string);
        }
        static double getweight()
        {
            double weight;
            string weight_str;
            Console.Write("Please enter your weight(lbs): ");
            weight_str = Console.ReadLine();
            weight = Convert.ToDouble(weight_str);
            return (weight);
        }
        static double calc_bmi(double height, double weight)
        {
            double bmi;
            bmi = (weight / Math.Pow(height, 2)) * 703;
            return (bmi);
        }
        static double getage()
        {
            double age;
            string age_str;
            Console.Write("Please enter your age: ");
            age_str = Console.ReadLine();
            age = Convert.ToDouble(age_str);
            return (age);
        }
        static double getsex()
        {
            double sex;
            string sex_str;
            Console.Write("Please enter your sex (1 for male, 0 for female): ");
            sex_str = Console.ReadLine();
            sex = Convert.ToDouble(sex_str);
            return (sex);
        }
        public static void BFPEval(double bfp, double sex)
        {
            if (sex == 0)
            {
                if ((bfp >= 10) && (bfp <= 13))
                    Console.WriteLine("Your BFP is {0} -- Essential Fat", bfp);
                else if (bfp <= 20)
                    Console.WriteLine("Your BFP is {0} -- Athletes", bfp);
                else if (bfp <= 24)
                    Console.WriteLine("Your BFP is {0} -- Fitness", bfp);
                else if (bfp <= 31)
                    Console.WriteLine("Your BFP is {0} -- Average", bfp);
                else if (bfp >= 32)
                    Console.WriteLine("Your BFP is {0} -- Obese", bfp);
                else
                    Console.WriteLine("Your BFP is invalid.");
            }
            else
            {
                if ((bfp >= 2) && (bfp <= 5))
                    Console.WriteLine("Your BFP is {0} -- Essential Fat", bfp);
                else if (bfp <= 13)
                    Console.WriteLine("Your BFP is {0} -- Athletes", bfp);
                else if (bfp <= 17)
                    Console.WriteLine("Your BFP is {0} -- Fitness", bfp);
                else if (bfp <= 24)
                    Console.WriteLine("Your BFP is {0} -- Average", bfp);
                else if (bfp >= 25)
                    Console.WriteLine("Your BFP is {0} -- Obese", bfp);
                else
                    Console.WriteLine("Your BFP is invalid.");
            }
        }
        public static void BMIBrackets(double bmi)
        {
            if (bmi < 18.5)
            {
                Console.WriteLine("Your BMI is {0}, underweight.", bmi);
            }
            else if (bmi < 22.9)
            {
                Console.WriteLine("Your BMI is {0}, normal range.", bmi);
            }
            else if (bmi < 24.9)
            {
                Console.WriteLine("Your BMI is {0}, at risk.", bmi);
            }
            else if (bmi < 29.9)
            {
                Console.WriteLine("Your BMI is {0}, moderately obese.", bmi);
            }
            else
            {
                Console.WriteLine("Your BMI is {0}, moderately obese.", bmi);
            }
        }
        public static void BFPBrackets(double bfp, double age, double sex)
        {
            if (age < 18)
            {
                Console.WriteLine("You are a mere child, and your body fat percentage is {0}.", bfp);
            }
            else
            {
                if (sex == 0)
                {
                    if (bfp < 13)
                    {
                        Console.WriteLine("Your bfp is {0}, essential fat.", bfp);
                    }
                    else if (bfp < 20)
                    {
                        Console.WriteLine("Your bfp is {0}, athletes.", bfp);
                    }
                    else if (bfp < 24)
                    {
                        Console.WriteLine("Your bfp is {0}, fitness.", bfp);
                    }
                    else if (bfp < 31)
                    {
                        Console.WriteLine("Your bfp is {0}, average.", bfp);
                    }
                    else
                    {
                        Console.WriteLine("Your bfp is {0}, obese.", bfp);
                    }
                }
                else
                {
                    if (bfp < 5)
                    {
                        Console.WriteLine("Your bfp is {0}, essential fat.", bfp);
                    }
                    else if (bfp < 13)
                    {
                        Console.WriteLine("Your bfp is {0}, athletes.", bfp);
                    }
                    else if (bfp < 17)
                    {
                        Console.WriteLine("Your bfp is {0}, fitness.", bfp);
                    }
                    else if (bfp < 24)
                    {
                        Console.WriteLine("Your bfp is {0}, average.", bfp);
                    }
                    else
                    {
                        Console.WriteLine("Your bfp is {0}, obese.", bfp);
                    }
                }
            }
        }
                    
    }
    class BFP
    {
        double BMI;
        double AGE;
        double SEX;

        public BFP(double bmi, double age, double sex)
        {
            BMI = bmi;
            AGE = age;
            SEX = sex;
        }
        public double Childbfpcalc()
        {
           double Cbfp;
           Cbfp = (1.51 * BMI) - (.7 * AGE) - (3.6 * SEX) + 1.4;
           return (Cbfp);
        }
        public double Adultbfpcalc()
        {
            double Abfp;
            Abfp = (1.2 * BMI) + (.23 * AGE) - (10.8 * SEX) - 5.4;
            return (Abfp);
        }
    }
}
