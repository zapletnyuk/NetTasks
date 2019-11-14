using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTasks.Tasks;
namespace NetTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int taskNumber = 0;
            while (!exit)
            {
                Console.Write("Enter number of task to solve: \n"+
                    "1. Partisions             5. Interesting Numbers \n"+
                    "2. Ways Without Crossing  6. Display In Three Steps \n"+
                    "3. Palindromic            7. Ways Counter \n"+
                    "4. Friends Pairs          8. Fence Painter \n");
                taskNumber = Convert.ToInt32(Console.ReadLine());
                switch (taskNumber)
                {
                    case 1:
                        Partitions.Display();
                        break;
                    case 2:
                        NumberOfWaysWithoutCrossing.Display();
                        break;
                    case 3:
                        Palindromic.Display();
                        break;
                    case 4:
                        FriendPairsFinal.Display();
                        break;
                    case 5:
                        InterestNum.Display();
                        break;
                    case 6:
                        WaysToCover.DisplayInThreeSteps();
                        break;
                    case 7:
                        WaysCounterClass.Display();
                        break;
                    case 8:
                        FencePainter.Display();
                        break;
                    default:
                        Console.WriteLine("Entered wrong number.");
                        break;
                };
                Console.WriteLine("Exit the program? True/False?");
                exit = Convert.ToBoolean(Console.ReadLine().ToLower());
            }
            Console.WriteLine("You've exited the program.");
            Console.ReadKey();
        }
    }
}
