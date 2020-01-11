using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    class Task1
    {

        /*

           Write a function:

           class Solution { public int solution(int[] A); }

           that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

           For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

           Given A = [1, 2, 3], the function should return 4.

           Given A = [−1, −3], the function should return 1.

           Write an efficient algorithm for the following assumptions:

           N is an integer within the range [1..100,000];
           each element of array A is an integer within the range [−1,000,000..1,000,000].


        */


        public int solution(int[] A)
        {
            //https://codereview.stackexchange.com/questions/139801/finding-the-smallest-missing-positive-number-in-an-array

            HashSet<int> temporal = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                temporal.Add(A[i]);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (i > 0 && !temporal.Contains(i))
                {
                    return i;
                }
            }
            return 0;
        }


        //static void Main(string[] args)
        //{
        //    Task1 execute = new Task1();
        //    int[] A = new int[6] { 10, 1, 5, 12, 16, 3 };
        //    Console.WriteLine(execute.solution(A));

        //    Console.ReadKey();
        //}
    }
}
