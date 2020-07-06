using System;

namespace RoomCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length: ");
            string length_entry = Console.ReadLine();
            double length = double.Parse(length_entry);
            Console.Write("Enter Width: ");
            string width_entry = Console.ReadLine();
            double width = double.Parse(width_entry);

            double roomArea = length * width;
            Console.WriteLine("Area: " + roomArea);
            Console.WriteLine("Permiter: " + ((length * 2) + (width * 2)));

            if (roomArea >= 650)
            {
                Console.WriteLine("This is a large-sized room.");
            }
            else if (roomArea >= 250)
            {
                Console.WriteLine("This is a medium-sized room.");
            }
            else if (roomArea >= 1)
            {
                Console.WriteLine("This is a small-sized room.");
            }

            Console.WriteLine("Volume: " + (roomArea * 10));

            /*Console.Write("Continue? y/n): ");
            char userContinue = Console.ReadLine();

            if (userContinue = "n")
            {
                Console.WriteLine("Thank you for using the Room Detail Generator!");
            }
            else if (userContinue = "y")
            {
                Console.WriteLine("Thank you for using the Room Detail Generator!");
            }
            */
        }
    }
}
