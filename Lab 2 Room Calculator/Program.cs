using System;

namespace Lab_2_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal roomLength, roomWidth, roomHeight;
            decimal roomArea, roomPerimeter, roomVolume;
            char continueEntry = 'y';

            while (continueEntry == 'y')
            {
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!\n");

                Console.Write("Enter Length: ");
                roomLength = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                roomWidth = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Height: ");
                roomHeight = decimal.Parse(Console.ReadLine());


                roomArea = roomLength * roomWidth;
                Console.WriteLine($"Area: {roomArea}");

                roomPerimeter = 2 * (roomLength + roomWidth);
                Console.WriteLine($"Perimeter: {roomPerimeter}");

                roomVolume = roomLength * roomWidth * roomHeight;
                Console.WriteLine($"Volume: {roomVolume}\n");

                continueEntry = ' ';
                while ((continueEntry != 'y') && (continueEntry != 'n'))
                {
                    Console.WriteLine("Would you like to continue (y/n)?");
                    continueEntry = char.Parse(Console.ReadLine().ToLower());
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Thank you for your time, Goodbye!");
            Console.ReadKey();
        }
    }
}
