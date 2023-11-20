

using System;

namespace myApplication
{
    class Program
    {
        public static void Main(string[] args) 
        {
            // outputs text to the screen
            Console.WriteLine("Hello you!");
            Console.WriteLine("Very well thank you");
            Console.WriteLine(5 + 5);

            // outputs text on the same line
            Console.Write("this will ..");
            Console.Write("write this here .. ");

            // declaring variables
            string forename = "Peter";
            string surname = "Smith";
            int num = 100;
            bool status = true;
            double num_dec = 6.25;

            const int con_num = 500;

            // output the variable
            Console.WriteLine();
            Console.WriteLine("The number is " + con_num);
        
        }
    }
}

