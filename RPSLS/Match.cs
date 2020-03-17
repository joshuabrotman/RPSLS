using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Match
    {
        public string winner;
        public Player1 p1 = new Player1();
        public Player2 p2 = new Player2();
        public List<string> gesture = new List<string>();
        

        public void Begin() 
        {
            gesture.Add("rock");
            gesture.Add("scissors");
            gesture.Add("paper");
            gesture.Add("lizard");
            gesture.Add("spock");

            int round;
            string winner;

            
            int userInput = 0;
            Console.WriteLine("Enter 1 for Human VS Human - 2: Human VS computer - 3: Computer VS Computer:");
            userInput = Convert.ToInt32(Console.ReadLine());


            //switch to make player1.isHuman and player2.is Human accordingly
            //instantiate players
            switch (userInput)
            {
                case 1:
                    p1.isHuman = true;
                    p2.isHuman = true;
                    break;
                case 2:
                    p1.isHuman = true;
                    p2.isHuman = false;
                    break;       
                case 3:
                    p1.isHuman = false;
                    p2.isHuman = false;
                    break;
                default:
                    Console.WriteLine("invalid");
                break;
            }



            //player1 goes first
            //if human, prompt for input
            //if not, generate random

            while (p1.score != 2 && p2.score != 2)
            {


                if (p1.isHuman)
                {
                    p1.currentGesture = p1.PlayHand();
                }
                else
                {
                    p1.currentGesture = p1.PlayRandomHand();
                }

                if (p2.isHuman)
                {
                    p2.currentGesture = p2.PlayHand();
                }
                else
                {
                    p2.currentGesture = p2.PlayRandomHand();
                }




                //compare gestures
                if ((p1.currentGesture == gesture[0] && p2.currentGesture == gesture[1]) ||
                   (p1.currentGesture == gesture[1] && p2.currentGesture == gesture[2]) ||
                   (p1.currentGesture == gesture[2] && p2.currentGesture == gesture[0]) ||
                   (p1.currentGesture == gesture[0] && p2.currentGesture == gesture[3]) ||
                   (p1.currentGesture == gesture[3] && p2.currentGesture == gesture[4]) ||
                   (p1.currentGesture == gesture[4] && p2.currentGesture == gesture[1]) ||
                   (p1.currentGesture == gesture[1] && p2.currentGesture == gesture[3]) ||
                   (p1.currentGesture == gesture[3] && p2.currentGesture == gesture[2]) ||
                   (p1.currentGesture == gesture[2] && p2.currentGesture == gesture[4]) ||
                   (p1.currentGesture == gesture[4] && p2.currentGesture == gesture[0]))
                {
                    Console.WriteLine("Player1 Wins the round!");
                    p1.score++;
                }
                else if ((p2.currentGesture == gesture[0] && p1.currentGesture == gesture[1]) ||
                   (p2.currentGesture == gesture[1] && p1.currentGesture == gesture[2]) ||
                   (p2.currentGesture == gesture[2] && p1.currentGesture == gesture[0]) ||
                   (p2.currentGesture == gesture[0] && p1.currentGesture == gesture[3]) ||
                   (p2.currentGesture == gesture[3] && p1.currentGesture == gesture[4]) ||
                   (p2.currentGesture == gesture[4] && p1.currentGesture == gesture[1]) ||
                   (p2.currentGesture == gesture[1] && p1.currentGesture == gesture[3]) ||
                   (p2.currentGesture == gesture[3] && p1.currentGesture == gesture[2]) ||
                   (p2.currentGesture == gesture[2] && p1.currentGesture == gesture[4]) ||
                   (p2.currentGesture == gesture[4] && p1.currentGesture == gesture[0]))
                {
                    Console.WriteLine("Player2 Wins the round!");
                    p2.score++;
                }
                else if (p2.currentGesture == p1.currentGesture)
                {
                    Console.WriteLine("Tie round!");
                }
                else
                {
                    Console.WriteLine("Bad Input!");
                }

                //display winner
                if(p1.score < p2.score)
                {
                    winner = "Player2 wins the Game!";
                }
                else if (p1.score > p2.score)
                {
                    winner = "player1 wins the Game!";
                }
                else
                {
                    winner = "error";
                }
                Console.WriteLine(winner);

                Console.ReadKey();

            }



        }

    }


}
