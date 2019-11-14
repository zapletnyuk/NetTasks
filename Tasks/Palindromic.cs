using System;
namespace NetTasks.Tasks
{
    /// <summary>
    /// Class for calculating the longest palindromic sequence
    /// </summary>
    public static class Palindromic
    {
        /// <summary>
        /// Method for calculating the longest palindromic sequence
        /// </summary>
        /// <param name="input">String not more than 100 symbols </param>
        /// <returns>int longest palindromic sequence </returns>
        public static int Longest(string input)
        {
            int length = input.Length;
            int i, j;
            int substringLength;

            // Create a table to store results of subproblems 
            int[,] TableStoreResults = new int[length, length];

            // Strings of length 1 are palindrome of lentgh 1 
            for (i = 0; i < length; i++)
                TableStoreResults[i, i] = 1;


            for (substringLength = 2; substringLength <= length; substringLength++)
            {

                for (i = 0; i < length - substringLength + 1; i++)
                {

                    j = i + substringLength - 1;


                    if (input[i] == input[j] && substringLength == 2)
                    {
                        TableStoreResults[i, j] = 2;
                    }

                    else if (input[i] == input[j])
                    {
                        TableStoreResults[i, j] = TableStoreResults[i + 1, j - 1] + 2;
                    }
                    else
                    {
                        TableStoreResults[i, j] = Math.Max(TableStoreResults[i, j - 1], TableStoreResults[i + 1, j]);
                    }
                }

            }

            return TableStoreResults[0, length - 1];
        }

        /// <summary>
        /// Show I / O information  
        /// </summary>
        public static void Display()
        {
            Console.WriteLine("Given a string which we have to check how many symbols have the biggest palindrome which is included in the given one.");
            Console.Write("Input: ");
            string input = Console.ReadLine();

            if (input.Length > 100)
            {
                Console.WriteLine("Error: String not more than 100 symbols ");
                return;
            }

            Console.Write("Output: " + Longest(input));
        }

    }
}
