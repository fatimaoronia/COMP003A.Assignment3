// Author: Fatima Oronia
// Course: COMP003A
// Purpose:Assignment 3

// If-Else Section (Numeric to Letter Grade)

using System;

namespace COMP003A.Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numeric grade (0-100): ");
            double numericGrade;
            if (double.TryParse(Console.ReadLine(), out numericGrade))
            {
                if (numericGrade >= 0 && numericGrade <= 100)
                {
                    if (numericGrade >= 90)
                        Console.WriteLine("Letter Grade: A");
                    else if (numericGrade >= 80)
                        Console.WriteLine("Letter Grade: B");
                    else if (numericGrade >= 70)
                        Console.WriteLine("Letter Grade: C");
                    else if (numericGrade >= 60)
                        Console.WriteLine("Letter Grade: D");
                    else
                        Console.WriteLine("Letter Grade: F");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            // Switch Section (Integer to String Day)
            Console.Write("Enter integer day (1-7): ");
            int numericDay;
            if (int.TryParse(Console.ReadLine(), out numericDay))
            {
                switch (numericDay)
                {
                    case 1:
                        Console.WriteLine("String Day: Monday");
                        break;
                    case 2:
                        Console.WriteLine("String Day: Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("String Day: Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("String Day: Thursday");
                        break;
                    case 5:
                        Console.WriteLine("String Day: Friday");
                        break;
                    case 6:
                        Console.WriteLine("String Day: Saturday");
                        break;
                    case 7:
                        Console.WriteLine("String Day: Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid day!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}

        

    