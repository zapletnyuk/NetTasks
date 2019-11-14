using System;
using static System.Int32;

namespace NetTasks.Tasks
{
    public static class InterestNum
    {
        public static int[] nums = { 1, 1, 3, 5, 11, 21 };
        public static void Input()
        {
            int p;
            if (TryParse(Console.ReadLine(), out p) && p < nums.Length && p >= 0)
            {
                Console.WriteLine("Selected number : " + nums[p]);
            }
            else
            {
                Console.WriteLine("Error. Try again.\n");
                Input();
            }
        }
        public static void Display()
        {
            Console.WriteLine("The goal: To find which is the member of position n in our interesting row.");
            Console.WriteLine("Enter position of number. Possible positions: 0 to {0}", nums.Length - 1);
            Input();
        }
    }
}