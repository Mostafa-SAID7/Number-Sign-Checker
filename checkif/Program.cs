using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        try
        {
            int number = Convert.ToInt32(input);
            Console.WriteLine(CheckSign(number));
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static string CheckSign(int num)
    {
        if (num > 0)
            return "The number is positive.";
        else if (num < 0)
            return "The number is negative.";
        else
            return "The number is zero.";
    }
}
// This program prompts the user to enter a number and checks if it is positive, negative, or zero.
// It uses a method called CheckSign to determine the sign of the number.
// The program handles invalid input by catching exceptions and displaying an error message.
// The CheckSign method returns a string indicating the sign of the number.
// The program is simple and demonstrates basic input handling, method usage, and conditional statements in C#.
// It is a good example of how to create a console application that interacts with the user and performs basic operations.
// The program can be further enhanced by adding more features, such as allowing the user to enter multiple numbers,