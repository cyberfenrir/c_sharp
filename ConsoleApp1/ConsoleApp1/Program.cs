using System;
using System.Transactions;

namespace ConsoleApp1 { 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for iteration: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = -3; i < a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}