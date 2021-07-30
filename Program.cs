using System;
using System.Reflection.Metadata.Ecma335;

namespace Calculator_Lab1
{

    class Calculation
    {  
       public static double typecast(string num)
        {
            double result = double.NaN;

            double i = 0;
            while (!double.TryParse(num, out i))
            {
                Console.Write("This is not valid value. Please enter the other value again: ");
                num = Console.ReadLine();
            }

            result = Convert.ToDouble(num);

            return result;
        } 
        public static double calcuate(string oper, double num1, double num2)
        {
            double result = double.NaN;

            switch (oper)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                        result = double.NaN;
                    break;

                default:
                    result = double.NaN;
                    break;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;

            while (check) { 

            Console.WriteLine("\nThe calculator is operating now\n");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Select an option from the following list\n\n\n");
            Console.WriteLine("\t 1. Add  :  Please,type 'a' ");
            Console.WriteLine("\t 2. Subtract  :  Please,type 's'");
            Console.WriteLine("\t 3. Multiply  :  Please,type 'm'");
            Console.WriteLine("\t 4. Divide  :  Please,type 'd'\n\n\n");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Type your option here, and press Enter :");

            string oper = Console.ReadLine();
            while (oper != "a" && oper != "s" && oper != "m" && oper != "d")
                {
                    Console.WriteLine("You've entered invalid value. Please press proper key again.");
                    oper = Console.ReadLine();
                }
            


            Console.WriteLine("\n\nType a first number for calculating, and then press Enter : ");
            double num1 = Calculation.typecast(Console.ReadLine());

            Console.WriteLine("\n\nType a second number for calculating, and then press Enter : ");
            double num2 = Calculation.typecast(Console.ReadLine());



            double result = Calculation.calcuate(oper, num1, num2);


                try
                {
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("\n\nSorry... the result has error value...");
                    }
                    else
                        Console.WriteLine("\n\n\n\nYour result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Type :" + e.GetType().ToString() + "Error Message : " + e.Message);
                }


            Console.WriteLine("\n\nIf you want to end this app, please press 'e'. (or press any other key to continue) ");
                string token = Console.ReadLine();


                if (token == "e")
                {
                    check = false;
                    Console.WriteLine("\n\n\nThank you for using our calculation\n\n\n");
                }
                else
                {
                    Console.WriteLine("\n\n\nContinue calcultion ....\n\n\n");
                
                }

               
                
        }
        }
    }
}
