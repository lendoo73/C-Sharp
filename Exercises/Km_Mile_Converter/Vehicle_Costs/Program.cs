using System;

namespace VehicleCosts
{
    class Program
    {
        static double user_input(string expense) {
            Console.Write(expense + ": ");
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

        public static void Main (string[] args) {

            Console.WriteLine ("Pleaseenter the yearly costs for for the following expenses incurred from operating your vehicle:");
        
            string[] expenses = {
                "fuel",
                "insurance",
                "loan payment",
                "maintenance",
                "oil",
                "tyres"
            };

            double total = 0;
            for (int i = 0; i < expenses.Length; i ++) {
            total += user_input(expenses[i]);
            }

            Console.WriteLine("The total yearly cost of your car is £{0:0.00}", total);
            Console.WriteLine("The average cost for one month is £{0:0.00}", (total / 12));
        }
    }
}
