using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidGenerator
{
    class Program
    {
        static void DrawPyramid(int userInput)
        {
            for(int currentRow = 1; currentRow <= userInput; currentRow++)
            // On each row, up to the number of rows entered by the users, do:, then move to next row
            {
                for(int NumSpaces = currentRow; NumSpaces <= userInput; NumSpaces++) 
                // Figures out how many double spaces to put before the first star on the first line
                // Loops until NumSpaces equals the number entered by the user.
                {
                    Console.Write("  "); // Double space
                    // Write two spaces
                }
                for(int NumStars = 1; NumStars <= 2 * currentRow - 1; NumStars++) 
                // Writes the required number of stars for each row. - 1 makes NumStars an odd number.
                // NumStars = 1; While NumStars is less or equal to 2 times the currentRow minus 1
                // 1st: 2 * 1 - 1 = 1. One star :: 2nd: 2 * 2 - 1 = 3 stars :: 3rd: 2 * 3 - 1 = 5 stars
                {
                    Console.Write("*" + " "); // Single space
                    // Write one * plus a space
                }
                Console.WriteLine();
                // Moves the cursor to the next line
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number between 1 and 20: ");
            int numRows = Convert.ToInt32(Console.ReadLine());
            DrawPyramid(numRows);
        }
    }
}
