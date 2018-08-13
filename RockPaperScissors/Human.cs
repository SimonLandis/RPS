using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public override void PlayerScore()
        {
        }

        public override void GetUserName()
        {
            Console.WriteLine("Please enter your name.\n");
            userName = Console.ReadLine();
        }

        public override void MakeChoice()
        {
            Console.WriteLine("OK, please make your selection. Your options are: rock, paper, scissors, lizard or spock");
            string playerChoice = Console.ReadLine().ToLower();
            switch (playerChoice)
            {
                case "rock":
                    choice = playerChoice;
                    break;
                case "paper":
                    choice = playerChoice;
                    break;
                case "scissors":
                    choice = playerChoice;
                    break;
                case "lizard":
                    choice = playerChoice;
                    break;
                case "spock":
                    choice = playerChoice;
                    break;
                default:
                    Console.WriteLine("I'm sorry that selection isn't valid, please choice from rock, paper, scissors, lizard or spock.");
                    break;
            }
        }
    }
}