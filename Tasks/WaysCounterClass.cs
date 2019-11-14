using System;
namespace NetTasks.Tasks
{
    public class WaysCounterClass
    {
        public static int n { get; set; }
        public static int m { get; set; }
        public static int CountWays()
        {
            int[] count = new int[n + 1];
            count[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i > m)
                    count[i] = count[i - 1] + count[i - m];
                else if (i < m)
                    count[i] = 1;
                else
                    count[i] = 2;
            }
            return count[n];
        }


        public static void Input()
        {
            bool check = true;
            Console.WriteLine("Given a floor of size n x m and tiles of size 1 x m. " +
                        "The problem is to count the number of ways to tile the given floor using 1 x m tiles. " +
                        "A tile can either be placed horizontally or vertically.");
            do
            {
                try
                {
                   
                    Console.WriteLine("Enter n:");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter m:");
                    m = Convert.ToInt32(Console.ReadLine());

                    if (m < 0 || n < 0)
                    {
                        throw new Exception("Digits are negative.");
                    }
                    if (m < 2) { throw new Exception("M is smaller than 2."); }
                    check = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error!" + ex.Message);
                }
            }
            while (check);
        }

        public static void Display()
        {
            Input();
            Console.WriteLine("Number of ways = " + CountWays());
        }
    }
}