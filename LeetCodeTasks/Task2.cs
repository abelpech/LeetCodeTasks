using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    class Task2
    {
        /*
         * Given a positive integer N, prints the consecutive numbers from 1 to N, each on a separate
         * line. However, any number divisible by 2,3 or 5 should be replaced by the word Codility, Test or 
         * Coders respectively.
         * 
         * If a number is divisible by more than one of the number: 2, 3 or 5, it should be replaced by a
         * concatenation of the respective words Codility, Test and Coders in this given order. For 
         * example, numbers divisible by both 2 and 3 should be replaced by CodilityTest and numbers divisible
         * by all three numbers: 2, 3 and 5, should be replaced by CodilityTestCoders.
         */
        public void solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 1; i <= N; i++)
            {

                if ((i % 2) == 0 && (i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine("CodilityTestCoders");
                }
                else if ((i % 2) == 0 && (i % 3) == 0)
                {
                    Console.WriteLine("CodilityTest");
                }
                else if ((i % 2) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine("CodilityCoders");
                }
                else if ((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine("TestCoders");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Codility");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Test");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Coders");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }

        //static void Main(string[] args)
        //{
        //    Task2 ejecutar = new Task2();
        //    ejecutar.solution(24);
        //    Console.ReadKey();
        //}
    }
}
