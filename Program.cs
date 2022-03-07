using System;
using System.Threading;

namespace SimpleDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1, player2;
            Random rand = new Random();

            int player1_Points = 0;
            int player2_Points = 0;

            char x;

            do {
                Console.Clear();
                Console.WriteLine(".. STARTING A NEW ROUND");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Press Any Key To Roll The Dice .. ");
                    Console.ReadKey();
                    player1 = rand.Next(1, 7);
                    Console.WriteLine($"\nYou Rolled -> {player1} \n");

                    Console.WriteLine("Waiting For Player2 ... \n");

                    Thread.Sleep(1000);
                    player2 = rand.Next(1, 7);
                    Console.WriteLine($"Enemy Rolled -> {player2} \n");

                    if (player1 > player2) {
                        player1_Points++;
                    }
                    else if (player1 < player2) {
                        player2_Points++;
                    }
                    else { Console.WriteLine("\t DRAW "); }

                    Console.WriteLine($"Result is \n\t Player1 : {player1_Points} \n\t Player2 : {player2_Points}\n\n ");
                }

                if (player1_Points > player2_Points)
                    Console.WriteLine("\t < YOU WIN >\n");
                else if (player1_Points < player2_Points)
                    Console.WriteLine("\t < YOU LOSE >\n");

                player1_Points = 0;
                player2_Points = 0;

                Console.WriteLine(" Do You Want To Play Again ? ( Y / N )");
                x = Convert.ToChar(Console.ReadLine());

            } while (x != 'n' && x!= 'N');
            Console.ReadKey();
        }
    }
}