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
    }


}
