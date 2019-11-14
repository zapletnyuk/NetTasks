using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTasks.Tasks
{
    public static class WaysToCover
    {  
        public static void DisplayInThreeSteps()
        {
            try
            {
                checked
                {
                    Console.Write("Please, input a distance to cover in: ");
                    int result = InThreeSteps(int.TryParse(Console.ReadLine(), out int parsed) ? parsed : 0);
                    Console.WriteLine($"Your possibility to cover the distance with 1, 2 and 3 steps = {result}");
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }     
        }

        public static int InThreeSteps(int distance)
        {          
            if (distance == 1 || distance == 0)
            {
                return 1;
            }
            else if (distance == 2)
            {
                return 2;
            }
            else
            {
                return InThreeSteps(distance - 3) +
                        InThreeSteps(distance - 2) +
                        InThreeSteps(distance - 1);
            }
        }
    }
}
