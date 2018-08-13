using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {

        public override void PlayerScore()
        {

        }
        public override void GetUserName()
        {

            userName = "Hal";

        }
        Random RandomNumber = new Random();

        public override void MakeChoice()
        {
            List<string> computerChoice = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            choice = computerChoice[RandomNumber.Next(0, 5)];

        }
    }
}