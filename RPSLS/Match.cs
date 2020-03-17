using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Match
    {

    
        public int SetOptions()
        {
            int userInput = 0;
            Console.WriteLine("Enter 1 for Human VS Human - 2: Human VS computer - 3: Computer VS Computer:");
            userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public void Begin() 
        {
            

            switch (SetOptions())
            {
                case 1:
                    Human HumanPlayer1 = new Human();
                    Human HumanPlayer2 = new Human();
                    break;
                case 2:
                    Human HumanPlayer = new Human();
                    Computer ComputerPlayer = new Computer();
                    break;
                case 3:
                    Computer ComputerPlayer1 = new Computer();
                    Computer ComputerPlayer2 = new Computer();
                    break;
            }


            
        }

    }


}
