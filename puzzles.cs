using System;
using System.IO;
using System.Diagnostics;

class Puzzles
{
    public static int Puzzle1()
    {
        int round = 0;
        int antiround = 0;
        int ai = 0;
        string choice; 
        int totalround = 0;
        bool again = false;
        int points = 0; 

        Random rnd = new Random();

        Console.WriteLine("Rock Paper Scissors Event");

            ai = rnd.Next(1,4);
           //1 is rock
           //2 is paper
           //3 is scissors

        while (totalround <= 5 && again == false)
        {
             ai = rnd.Next(1,4);
             Console.WriteLine("Please enter rock, paper or scissors.");
             choice = (Console.ReadLine()).ToLower();

             if (choice == "rock" && ai == 1)
             {
                Console.WriteLine("Prof Hirani chose paper, you tie.");
                totalround++;
             }
             if (choice == "rock" && ai == 2)
             {
                Console.WriteLine("Prof Hirani chose paper, you lose.");
                antiround++;
                totalround++;
             }
             if (choice == "rock" && ai == 3)
             {
                Console.WriteLine("Prof Hirani chose scissors, you win.");
                round++;
                totalround++;
             }
 
             if (choice == "paper" && ai == 1)
             {
                Console.WriteLine("Prof Hirani chose rock, you win.");
                round++;
                totalround++;                
             }
             if (choice == "paper" && ai == 2)
             { 
                Console.WriteLine("Prof Hirani chose paper, you tie.");
                totalround++;
             } 
             if (choice == "paper" && ai == 3)
             {
                Console.WriteLine("Prof Hirani chose scissors, you lose.");
                antiround++;
                totalround++;
             }
 
             if (choice == "scissors" && ai == 1)
             {
                Console.WriteLine("Prof Hirani chose rock, you lose.");
                antiround++;
                totalround++;
             }
             if (choice == "scissors" && ai == 2)
             {
                Console.WriteLine("Prof Hirani chose paper, you win.");
                round++;
                totalround++;
             }
             if (choice == "scissors" && ai == 3)
             {
                Console.WriteLine("Prof Hirani chose scissors, you tie.");
                totalround++;
             }
             if((round >= antiround) && totalround == 5)
             {
                 Console.WriteLine("You win the majority of the rounds.");
                 again = true;
                 round = 0;
                 antiround = 0;
                 points = 3;
             }
             else if ((round < antiround) && totalround == 5)
             {
                 Console.WriteLine("You lose the majority of the rounds.");
                 Console.WriteLine("Try Again. Please press enter.");
                 Console.ReadLine();
                 totalround = 0;
                 round = 0;
                 antiround = 0;
                 points--;
             }
        }
        return points; 
    } 

    public static int Puzzle2()
    {
        Stopwatch sr = new Stopwatch();
        Random rnd = new Random();
        int rounds = 5; 
        int num1;
        int num2;
        int answer;
        int point = 0;
        double totaltime = 0;
        double t;

        Console.WriteLine("You must answer 5 questions in 5 seconds.");
        Console.WriteLine("Press Enter to Begin.");
        Console.ReadLine();
        for (int  i = 1; i <= rounds; i++)
        {
            point = 0;
            num1 = rnd.Next(1,19);
            num2 = rnd.Next(1,19);
            Console.Write("{0} + {1} = ", num1, num2);
            sr.Start();
            answer = int.Parse(Console.ReadLine());
            sr.Stop();
            totaltime = sr.Elapsed.TotalSeconds;
            if((num1+num2) == answer)
            {
                point++;
            }
            else
            {
                point--;
            }

            if (point == 5 && totaltime <= 5 && i >= 5)
            {
                Console.WriteLine("You Win");
            }
            else if (point != 5 && i >= 5)
            {
                Console.WriteLine(totaltime);
                Console.WriteLine("You Lose. Press Enter to Retry!");
                Console.ReadLine();
                i = 0;
                totaltime = 0;
            }
        }
        return point;
    } 
    
}