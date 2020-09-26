using System;

namespace DIY_Total_Purchase
{
    class Program
    {
        static double user_input(string price) {
            Console.Write(price + ": ");
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

        static string create_margin(string price) {
            string margin = "";
            int margin_length = 6 - price.Length;
            for (int i = 0; i < margin_length; i ++) {
                margin += " ";
            }
            return margin;
        }


        public static void Main (string[] args) {
            Console.WriteLine ("Please enter the prices of your five items:");

            double sub_total = 0;
            for (int i = 1; i < 6; i ++) {
                sub_total += user_input("Price of item" + i);
            }
            Console.WriteLine("****** Recipe ******");
            Console.WriteLine("Sub-total:" + create_margin(Convert.ToString(sub_total * 0.8)) + "£{0:0.00}", (sub_total * 0.8));
            Console.WriteLine("VAT      :" + create_margin(Convert.ToString(sub_total * 0.2)) + "£{0:0.00}", (sub_total * 0.2));
            Console.WriteLine("Total    :" + create_margin(Convert.ToString(sub_total)) + "£{0:0.00}", sub_total);
        }
    }
}
