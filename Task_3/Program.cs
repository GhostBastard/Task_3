using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        public static void FiboRecursive(int n0,int n1, int n)
        {
            int temp;
            Console.Write(n0 + " ");
            temp = n0+n1;
            n0 = n1;
            n1 = temp;
            n = n - 1;
            if (n != 0)
                FiboRecursive(n0, n1, n);
            
        }
        public static void FiboIterative(int n0, int n1, int n)
        {
            int temp;
            for (int i = n; i >0 ; i--)
            {
                Console.Write(n0 + " ");
                temp = n0 + n1;
                n0 = n1;
                n1 = temp;
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n"+n+ " Fibonacci number with recursive way. Time complexity - T(2^n), space complexity - O(n).\n");
            FiboRecursive(0, 1, n);

            Console.Write("\n\n" + n + " Fibonacci number with iterative way. Time complexity - T(n), space complexity - O(n).\n");
            FiboIterative(0, 1, n);
            Console.ReadKey();

        }
    }
}
