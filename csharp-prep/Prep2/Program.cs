using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        
        if (percentage >= 90)
        {
            Console.WriteLine("You have an A in the class! ");
        }
        else if(percentage >= 80)
        {
            Console.WriteLine("You have a B in the class!");
        }
        else if(percentage >= 70)
        {
            Console.WriteLine("You have a C in the class.");
        }
        else if(percentage >= 60)
        {
            Console.WriteLine("You have a D in the class...");
        }
        else if(percentage < 60)
        {
            Console.WriteLine("You got an F you loser! ");
        }
    }
}