using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTasks.Tasks
{
    class FencePainter
    {
        public static int posts { get; set; }
        public static int paints { get; set; }

        public static void Input()
        {
            Console.WriteLine("Given a fence with n posts and k colors, find out the number of ways of painting the fence,\n" +
                               "such that at most 2 adjacent posts have the same color.");
            bool check = true;
            do
            {
                try
                {
                    Console.WriteLine("Please input the number of posts: ");
                    posts = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please input the number of paints: ");
                    paints = Convert.ToInt32(Console.ReadLine());
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (check);
        }

        public static int WaysToPaintTheFence()
        {
            FencePainter.Input();
            int total = paints;
            int diff = paints;
            int same;
            for (int i = 2; i <= posts; i++)
            {
                same = diff;
                diff = total * (paints - 1);
                total = (same + diff);
            }
            return total;
        }
        public static void Display()
        {
            Console.WriteLine(WaysToPaintTheFence());
        }

    }
}
