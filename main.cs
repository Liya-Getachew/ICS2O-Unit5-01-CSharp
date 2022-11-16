// Created by: liya getachew
// Created on: Oct 19 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function generates a random number from 1-6
        Random random = new System.Random();
        int randomNumber = random.Next(1, 6);

        int valueFromInput;

        Console.WriteLine("guess a number from 1-6 and see if you're right or wrong");
        Console.WriteLine("");

        Console.Write("insert guess here: ");
        valueFromInput = Convert.ToInt32(Console.ReadLine());

        if (valueFromInput == randomNumber)
        {
            Console.WriteLine("You'reeee....RIGHT! The answer was " + randomNumber + ". ");
        }

        if (valueFromInput != randomNumber)
        {
            Console.WriteLine("You'reeee....WRONG! Try again.");
        }

        Console.WriteLine("\nDone.");
    }
}