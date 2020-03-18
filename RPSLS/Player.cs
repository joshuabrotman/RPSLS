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
        public int score;



        public Player()
        {
            string currentGesture;
            int score;
        }

        public virtual string ChooseGesture()
        {
            string handPlayed = "";
            while(handPlayed != "scissors" && handPlayed != "rock" && handPlayed != "paper" && handPlayed != "lizard" && handPlayed != "spock")
            {
                Console.WriteLine("Enter the hand you want to play: ");
                handPlayed = Console.ReadLine();
            }
            
            return handPlayed;
        }




    }
}
