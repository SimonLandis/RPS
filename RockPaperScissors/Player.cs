using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public string userName;
        public string choice;
        public int playerScore = 0;
        public Player()
        {
        }
        public virtual void PlayerScore()
        {
        }
        public virtual void MakeChoice()
        {   
        }
        public virtual void GetUserName()
        { }
    }
} 

