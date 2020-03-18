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
        public int round =1;
        public List<string> gesture = new List<string>();
        public Player p1;
        public Player p2;

        public void Begin() 
        {
            gesture.Add("rock");
            gesture.Add("scissors");
            gesture.Add("paper");
            gesture.Add("lizard");
            gesture.Add("spock");

            
            string winner;

            
            int userInput = 0;
            while (userInput != 1 && userInput != 2 && userInput != 3)
                { 
                    Console.WriteLine("Enter 1 for Human VS Human - 2: Human VS computer - 3: Computer VS Computer:");
                    try
                    {
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        userInput = 0;
                    }
                    if (userInput != 1 && userInput != 2 && userInput != 3) { Console.WriteLine("Invalid Option!"); }
            }
            

            //switch to make player1.isHuman and player2.is Human accordingly
            //instantiate players
            switch (userInput)
            {
                case 1:
                    p1 = new Human();
                    p2 = new Human();
                    break;
                case 2:
                    p1 = new Human();
                    p2 = new Robot();
                    break;       
                case 3:
                    p1 = new Robot();
                    p2 = new Robot();
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


                p1.currentGesture = p1.ChooseGesture();
                p2.currentGesture = p2.ChooseGesture();
                



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
                if(p1.score < p2.score && round == 3)
                {
                    winner = "Player2 wins the Game!";
                    Console.WriteLine(winner);
                }
                else if (p1.score > p2.score && round == 3)
                {
                    winner = "Player1 wins the Game!";
                    Console.WriteLine(winner);
                }
                else if (p1.score == p2.score && round == 3)
                {
                    winner = "Tie!";
                    Console.WriteLine(winner);
                }
                

                Console.ReadKey();
                Console.WriteLine("Press enter to continue: ");
                round++;

            }



        }

    }


}
