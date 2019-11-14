using System;

namespace NetTasks
{
    class NumberOfWaysWithoutCrossing
    {
        static public int InputNum { get; set; }

        static public void Input()
        {
            Console.WriteLine("Program to count a number of ways to connect n (where n is even) points on a circle such that no two connecting lines cross " +
                              "each other and every point is connected with one other point.");
            Console.Write("The number of points- n which is an integer, where n is even: ");
            bool check = true;
            do
            {
                try
                {
                    int InputNum = Convert.ToInt32(Console.ReadLine());
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (check);
        
        }

        static public int catalanDP(int n)
        {
            if(n % 2 == 1)
            {
                return 0;
            }

            int[] catalan = new int[n + 1];

            catalan[0] = catalan[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                catalan[i] = 0;
                for (int j = 0; j < i; j++)
                    catalan[i] += catalan[j] *
                                  catalan[i - j - 1];
            }

            return catalan[n];
        }

        static public int countWays(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Invalid");
                return 0;
            }

            return catalanDP(n / 2);
        }

        static public void Display()
        {
            Input();
            Console.WriteLine(countWays(InputNum));
            Console.ReadKey();
        }
    }
}
