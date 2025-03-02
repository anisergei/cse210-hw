using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string answere = Console.ReadLine();
        int percentage = int.Parse(answere);

        string letter ="";

        if (percentage >= 90)
        {
            letter ="A";
        }
        else if (percentage >=80)
        {
            letter ="B";
        }
        else if (percentage >=70)
        {
            letter ="C";
        }
        else if (percentage >=60)
        {
            letter ="D";
        }
        else  
        {
            letter ="F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percentage >=70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("Try again next time!");
        }        
    }
}