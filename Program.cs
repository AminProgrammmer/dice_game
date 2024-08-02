using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberplayerroll;
            int enemynumberplayerroll;

            int playerpints = 0;
            int Apoints = 0;

            int allplayerscore = 0;
            int allaiplayerscore = 0;
            Random randomint = new Random();

           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("please any key to start rolll");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                numberplayerroll = randomint.Next(1, 7);
                Console.WriteLine("you rolleda      " + numberplayerroll);
                Console.ResetColor();

                Console.WriteLine(".......");
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;

                enemynumberplayerroll = randomint.Next(1, 7);
                Console.WriteLine("enemy player Ai rolled a        " + enemynumberplayerroll);
                Console.ResetColor();
                allplayerscore += numberplayerroll;
                allaiplayerscore += enemynumberplayerroll;
                if (numberplayerroll > enemynumberplayerroll)
                {
                    playerpints++;
                    Console.WriteLine("you is winner in this round");
             }
                else if (enemynumberplayerroll > numberplayerroll)
                {
                    Apoints++;
                    Console.WriteLine("Ai is winner in this round");

                }
                else if (enemynumberplayerroll == numberplayerroll)
                {

                    Console.WriteLine("none of you managed by score this round");
                }






            }
            if (Apoints>playerpints)
            {
                Console.ForegroundColor = ConsoleColor.Blue;



                Console.WriteLine("the ai player is winner in this game     with" + allaiplayerscore + "score");

                Console.ResetColor();


            }

            else if(playerpints > Apoints)
            {
                Console.ForegroundColor = ConsoleColor.Red;



                Console.WriteLine(" you is winner in this game     with " + allplayerscore + "score");

                Console.ResetColor();
            }
            else if (playerpints == Apoints)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;



                Console.WriteLine("none of you managed by score in this game. you are equal");

                Console.ResetColor();
            }

            Console.ReadKey();


        }
    }
}
