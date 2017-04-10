//testing2
/* Dustin Short: Assignment 1, question 1: The goal of this program is to get accustome to useing C#. Also to demonstrait the task of reading an input from the user, doing something with it, and then writting an output to the screen. */
using System;

public class Assign1Question1
{
    public static void Main()
    {
        //Identifying variables and data types
        int numPenny, numNickle, numDime, numQuarter, numLoonie, numToonie;
        const double costPen = 0.01, costNick = 0.05, costDim = 0.10, costQuar = 0.25, costLoo = 1.00, costToo = 2.00;
        string name;
        double cash;

        //Prompt the user to enter your name
        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        //Prompt the user for the number of pennies they own
        Console.Write("Hello {0}, how many pennies do you own? =>",name);
        numPenny = Convert.ToInt32(Console.ReadLine());

        //Prompt the user for the number of nickles they own
        Console.Write("How many nickles do you own? =>");
        numNickle = Convert.ToInt32(Console.ReadLine());

        //Prompt the user for the number of dimes they own
        Console.Write("How many dimes do you own? =>");
        numDime = Convert.ToInt32(Console.ReadLine());

        //Prompt the user for the number of quarters they own
        Console.Write("How many quarters do you own? =>");
        numQuarter = Convert.ToInt32(Console.ReadLine());

        //Prompt the user for the number of loonies they own
        Console.Write("How many loonies do you own? =>");
        numLoonie = Convert.ToInt32(Console.ReadLine());

        //Prompt the user for the number of toonies they own
        Console.Write("How many toonies do you own? =>");
        numToonie = Convert.ToInt32(Console.ReadLine());

        //Calculate the total value of cash they have
        cash = numPenny*costPen+numNickle*costNick+numDime*costDim+numQuarter*costQuar+numLoonie*costLoo+numToonie*costToo;

        //Tell user how much money they have
        Console.WriteLine("{0} has {1:C} in his/her piggy-bank.", name, cash);

        //Since I'm using a mac I have to throw in a Console.Readline at the end of my code.
        Console.WriteLine("Press any key to end");
        Console.ReadLine();
    }
}

