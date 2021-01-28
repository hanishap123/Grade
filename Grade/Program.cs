// Author: Hanisha Pagarani
// Date: 01/28/2021
// Comments:  This C# Console application code demonstrates the use of 
// conditional statements after getting input from users

using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
          
            // Ask the user for input
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            // This variable gathers the user input
            string input = Console.ReadLine();

            // This variable stores the input after the input variable is parsed to integer
            int grade = int.Parse(input);
            
            // If the user inputs an integer of 98 and above, A+ is displayed
            if (grade >= 98)
            {
                Console.WriteLine("A+");
            }
            // If the user inputs an integer greater or equal to 92 and less than or equal to 97, A is displayed
            else if (grade >= 92 && grade <= 97)
            {
                Console.WriteLine("A");
            }
            // If the user inputs an integer of 90 or 91, A- is displayed
            else if (grade == 90 || grade == 91)
            {
                Console.WriteLine("A-");
            }
            // If the user inputs an integer of 88 or 89, B+ is displayed
            else if (grade == 88 || grade == 89)
            {
                Console.WriteLine("B+");
            }
            // If the user inputs an integer greater than or equal to 82 and less than or equal to 87, B is displayed
            else if (grade >= 82 && grade <= 87)
            {
                Console.WriteLine("B");
            }
            // If the user inputs an integer of 80 or 81, B- is displayed
            else if (grade == 80 || grade == 81)
            {
                Console.WriteLine("B-");
            }
            // If the user inputs an integer of 78 or 79, C+ is displayed
            else if (grade == 78 || grade == 79)
            {
                Console.WriteLine("C+");
            }
            // If the user inputs an integer greater than or equal to 72 and less than or equal to 77, C is displayed
            else if (grade >= 72 && grade <= 77)
            {
                Console.WriteLine("C");
            }
            // If the user inputs an integer of 70 or 71, C- is displayed
            else if (grade == 70 || grade == 71)
            {
                Console.WriteLine("C-");
            }
            // If the user inputs an integer of 68 or 69, D+ is displayed
            else if (grade == 68 || grade == 69)
            {
                Console.WriteLine("D+");
            }
            // If the user inputs an integer greater than or equal to 62 and less than or equal to 67, D is displayed
            else if (grade >= 62 && grade <= 67)
            {
                Console.WriteLine("D");
            }
            // If the user inputs an integer of 60 or 61, D- is displayed
            else if (grade == 60 || grade == 61)
            {
                Console.WriteLine("D-");
            }
            // If the user inputs an integer less than 60, F is displayed
            else if (grade < 60)
            {
                Console.WriteLine("F");
            }

            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);
        }
    }
}
