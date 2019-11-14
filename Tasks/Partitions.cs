using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTasks.Tasks
{
    public static class Partitions
    {
        static public int Number { get; set; }
        static public void Input()
        {
            Console.WriteLine("Find ways to write n as sum of two or more positive integers.");
            bool check = true;
            do
            {
                try
                {
                    Console.Write("Input number: ");
                    Number = Convert.ToInt32(Console.ReadLine());
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (check);
        }
        static public int FindPartitions(int n)
        {
            int[] p = new int[n + 1];
            p[0] = 1;
            for (int i = 1; i <= n; ++i)
            {
                int k = 1;
                while ((k * (3 * k - 1)) / 2 <= i)
                {
                    p[i] += (k % 2 != 0 ? 1 : -1) *
                        p[i - (k * (3 * k - 1)) / 2];
                    if (k > 0)
                    {
                        k *= -1;
                    }
                    else
                    {
                        k = 1 - k;
                    }
                }
            }
            return p[n];
        }
        static public void Display()
        {
            Input();
            Console.WriteLine($"Ways to write {Number} as sum of two or more positive integers: {FindPartitions(Number)}");
        }
    }
}
