using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Ai : Player
    {

        //member variables 




        //constructor
        public Ai(string playerName)
            :base(playerName)
        {
            this.playerName = playerName;
            Console.WriteLine("What is the player's Name?");

        }
           


        //member methods


    }
}
