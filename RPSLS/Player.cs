using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {

        public Player()
        {
            string currentHand;
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
                    return "rock";
                case 1:
                    return "paper";
                case 2:
                    return "scissors";
                case 3:
                    return "lizard";
                case 4:
                    return "spock";
            }

            return "unknown";

        }
        

    }
}
