using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Task1 execute = new Task1();
            int[] A = new int[6] { 10, 1, 5, 12, 16, 3 };
            Console.WriteLine(execute.solution(A));

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
