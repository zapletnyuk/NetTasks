﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.Write("Enter number of task to solve: ");
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

                        break;
                    case 8:

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
