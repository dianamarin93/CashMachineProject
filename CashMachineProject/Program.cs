using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachineProject
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Welcome to our store!");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the value of the tax receipt:");
                double sumT = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the bills: ");
                double sumE = Convert.ToDouble(Console.ReadLine());

                if (sumE > sumT)
                {
                    double restCustomer = sumE - sumT;
                    Console.WriteLine($"The rest of you is {restCustomer} lei");

                    while (restCustomer >= 200)
                    {
                        Console.WriteLine("You received 200 lei");
                        restCustomer -= 200;
                    }
                    while (restCustomer >= 100)
                    {
                        Console.WriteLine("You received 100 lei");
                        restCustomer -= 100;

                    }
                    while (restCustomer >= 50)
                    {
                        Console.WriteLine("You received 50 lei");
                        restCustomer -= 50;

                    }
                    while (restCustomer >= 10)
                    {
                        Console.WriteLine("You received 10 lei");
                        restCustomer -= 10;

                    }
                    while (restCustomer >= 5)
                    {
                        Console.WriteLine("You received 5 lei");
                        restCustomer -= 5;
                    }
                    while (restCustomer >= 1)
                    {
                        Console.WriteLine("You received 1 ron");
                        restCustomer -= 1;

                    }
                    while (restCustomer >= 0.5)
                    {
                        Console.WriteLine("You received 0.5 ron");
                        restCustomer -= 0.5;

                    }
                    while (restCustomer >= 0.1)
                    {
                        Console.WriteLine("You received 0.1 ron");
                        restCustomer -= 0.1;

                    }
                    while (restCustomer >= 0.05)
                    {
                        Console.WriteLine("You received 0.05 ron");
                        restCustomer -= 0.05;

                    }while (restCustomer >= 0.01)
                    {
                        Console.WriteLine("You received 0.01 ron");
                        restCustomer -= 0.01;

                    }
                }
                else
                {
                    double amountDue = sumT- sumE;
                    Console.WriteLine($"Insufficient fund, please enter the difference {amountDue} in lei");
                }

                Console.ReadKey();


            }

        }
    }
}
