using System;
namespace Averagely
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Hello there! Want to know your average test score? Enter your score.");
            System.Console.Write("Science1=");
            double score1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Science2=");
            double score2 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Science3=");
            double score3 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Science4=");
            double score4 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Science5=");
            double score5 = Convert.ToInt32(Console.ReadLine());
            double average = (score1+score2+score3+score4+score5)/5;
            System.Console.WriteLine($"Average:{average}");
            System.Console.WriteLine(new string('-',40));    
            if(average>4 && average<=5)
            {
                System.Console.WriteLine("You are an exellent student.");
            }        
            else if(average>3 && average<=4)
            {
                System.Console.WriteLine("You are a good student");
            }
            else if(average>0 && average<=3)
            {
                System.Console.WriteLine("You are a bad student");
            }
            else
            {
                System.Console.WriteLine("You have enterend an incorrect number.");
            }
        }
    }
}

