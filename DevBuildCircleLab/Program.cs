using System;
using System.Collections.Generic;

namespace DevBuildCircleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circles = new List<Circle>();
            bool keepGoing = true;

            while (keepGoing)
            {
                circles.Add(NewCircle());

                if (!Continue())
                {
                    keepGoing = false;
                    PrintCircles(circles);
                }
            }

        }

        public static Circle NewCircle()
        {
            Circle userCircle = new Circle(ValidRadius());
            Console.WriteLine("Circle made\n");
            return userCircle;
        }

        public static void PrintCircles(List<Circle> circles)
        {
            foreach(Circle circle in circles)
            {
                Console.WriteLine(circle);
            }
        }

        public static double ValidRadius()
        {

            string userAttempt = GetUserInput("Please enter your radius: ");

            try
            {
                double radius = double.Parse(userAttempt);
                if ( radius > 0)
                {
                    return radius;
                }
                else
                {
                    Console.WriteLine("That was not a valid radius. Please enter a number greater than 0.");
                    return ValidRadius();
                }
            }
            catch
            {
                Console.WriteLine("That was not a valid radius. Please enter a number greater than 0.");
                return ValidRadius();
            }

            
        }

        public static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();


            return output;
        }

        public static bool Continue()
        {
            string answer = GetUserInput("Continue? (y/n): ");

            if (answer.ToLower().Trim() == "y")
            {
                return true;
            }
            else if (answer.ToLower().Trim() == "n")
            {
                Console.WriteLine("Here are your circles:");
                return false;
            }
            else
            {
                Console.WriteLine("Please enter either yes or no to continue.");
                return Continue();
            }

        }
    }

    
}
