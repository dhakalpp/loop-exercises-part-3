using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*task 1*/
            int start = 1;
            int finish = 50;

            for (int i = start; 1 <= finish; i++)


                while (start <= finish)
                {
                    Console.WriteLine(start);
                    start++;
                }
            Console.WriteLine(" end of task 1");
            Console.ReadLine();

            /*task 2*/
            /*for loop*/
            Console.Clear();
            double total = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"please enter number {1}: ");
                total += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"total: {total}");
            Console.WriteLine(" end of task 2");
            Console.ReadLine();

            /*task 3*/
            Console.WriteLine("please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                if (i != 0 && i%2 == 0 )
                Console.WriteLine(i);
            }
            Console.WriteLine("task 3 complete");
             Console.ReadLine();

           
        }
    }
}
