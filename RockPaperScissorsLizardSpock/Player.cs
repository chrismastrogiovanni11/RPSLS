using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
   public class Player
    {
       //member variables 
       public string takeTurn;
       public string playerName;
       
       public int Wins;
       public int gestures;


       //constructor
        public Player()
        {
         playerName playername = null;
          Console.WriteLine("What is the player's name?");
          Console.ReadLine();
           

       }
       //member methods
       public void playerOptions()
       {
           List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
           Console.ReadLine();
       }
       public void PickGesture(Gestures)
       {
           Console.WriteLine("Please Select a Gesture 0 - 4");
           Console.ReadLine();
       }
      
  
                public void CompareGestures();
 


    }


























}

