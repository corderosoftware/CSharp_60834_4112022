using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static int Num1 = 5;
        static int Num2 = 9;
        static int Total = 0;

        static void Main(string[] args)
        {
            Total = Num1 + Num2;
            Console.WriteLine("El Total: " + Total);
        }
    }
}