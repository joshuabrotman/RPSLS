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
        public string name;
        public string playerName;



        public Player(string playerName)
        {
            string currentGesture;
            int score;
            this.playerName = playerName;
        }

        public virtual string ChooseGesture()
        {
            string handPlayed = "";
            while(handPlayed != "scissors" && handPlayed != "rock" && handPlayed != "paper" && handPlayed != "lizard" && handPlayed != "spock")
            {
                Console.WriteLine("Enter the hand you want to play: ("+playerName+") (Rock, Paper, Scissors, Spock, or Lizard)");
                handPlayed = (Console.ReadLine()).ToLower();
            }
            
            return handPlayed;
        }




    }
}
