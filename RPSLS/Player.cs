using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string currentGesture;
        public bool isHuman;
        public int score;



        public Player()
        {
            string currentGesture;
            bool isHuman;
            int score;
        }

        public string PlayHand()
        {
            string handPlayed;
            Console.WriteLine("Enter the hand you want to play: ");
            handPlayed = Console.ReadLine();
            return handPlayed;
        }

        public string PlayRandomHand()
        {
            int randomInt;
            Random random = new Random();
            randomInt = random.Next(0, 4);

            switch (randomInt)
            {
                case 0:
                    Console.WriteLine("Computer chose rock.");
                    return "rock";
                case 1:
                    Console.WriteLine("Computer chose paper.");
                    return "paper";
                case 2:
                    Console.WriteLine("Computer chose scissors.");
                    return "scissors";
                case 3:
                    Console.WriteLine("Computer chose lizard.");
                    return "lizard";
                case 4:
                    Console.WriteLine("Computer chose Spock.");
                    return "spock";
            }

            return "unknown";

        }
        

    }
}
