using System;

namespace KmMileConverter
{
    class Program
    {
        static double userInput(string unit) {
            Console.Write("Please enter a distance in " + unit + ": ");
            double input = 0;
            bool isNotCorrect = false;
            do {
                isNotCorrect = false;
                try {
                    input = Convert.ToDouble(Console.ReadLine());
                }
                catch(Exception error) {
                    Console.Write("Only numbers allowed, please try again: ");
                    isNotCorrect = true;
                }
            } while (isNotCorrect);
            return input;
        }
        static void Main(string[] args) {
            double miles = 0.621371192;
            double input = userInput("kilometres");
            Console.WriteLine(input + " km in Miles: " + input * miles + " mile(s).");
            input = userInput("miles");
            Console.WriteLine(input + " miles in kilometres: " + input / miles + " km.");
        }
    }
}
