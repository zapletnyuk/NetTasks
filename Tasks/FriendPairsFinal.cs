using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTasks.Tasks
{
    public static class FriendPairsFinal
    {
        static public int PersonsNumber { get; set; }

        static public void Input()
        {
            Console.WriteLine("Given n friends, each one can remain single or can be paired up with some other friend." +
                " Each friend can be paired only once. Find out the total number of ways in which friends can remain" +
                " single or can be paired up.");
           
            bool check = true;
            do
            {
                try
                {
                    Console.WriteLine("\nInput n:");
                    PersonsNumber = Convert.ToInt32(Console.ReadLine());
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (check);
         
        }
        static public int WaysNumberCounting()
        {
            int n = PersonsNumber;
            int[] arr = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i <= 2)
                    arr[i] = i;
                else
                    arr[i] = arr[i - 1] + (i - 1) * arr[i - 2];
            }

            return arr[n];
        }
        static public void Display()
        {
            Input();
            Console.WriteLine("Total number of ways: " + WaysNumberCounting());
        }
    }
}
