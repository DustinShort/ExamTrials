/* Dustin Short: Assignment 1, question 2: This program demonstrates the ability of the "if" statements to make decisions while including logical operators*/

using System;
public class Assign1Question2
{
    public static void Main()
    {
        //Identifying variables and data types
        int numDonuts;
        const double HST = 1.13, LuxTax = 0.25;
        string lastName;
        double totCost, costPerDonut=0.0;

        //Prompt the user to enter your last name
        Console.Write("Enter your last name: ");
        lastName = Console.ReadLine();

        //Prompt the user for how many donuts they want
        Console.Write("Hello {0}, how many donuts do you want? => ",lastName);
        numDonuts = Convert.ToInt32(Console.ReadLine());
        
        //If the user inputs 0 or a negative number, return an error
        if (numDonuts<=0)
        {
            Console.WriteLine("No silly goose, that doesn't make sense");
            return;
        }

        //Finding the cost per donut based on how many donuts bought.
        if (numDonuts>=12)
        {
            costPerDonut = 0.75;
        }

        if (numDonuts>6 && numDonuts<12)
        {
            costPerDonut = 0.9;
        }

        if (numDonuts>0 && numDonuts<=6)
        {
            costPerDonut = 1;
        }

        //Finding total cost before tax
        totCost = costPerDonut*numDonuts+LuxTax;

        //Including tax, where applicable
        if (numDonuts<12)
        {
            totCost = HST*totCost;
        }

        //Tell user how much money they owe
        Console.WriteLine("{0}, you owe {1:C} for {2}.", lastName, totCost, numDonuts);

        //Since I'm using a mac I have to throw in a Console.Readline at the end of my code.
        Console.WriteLine("Press any key to end");
        Console.ReadLine();
    }
}

