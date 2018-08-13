using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        List<string> computerChoice = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        public void GameStart()
        {
            Welcome();
            GameRules();
            PlayerSelection();
            GameRun();
        }
        public void GameRun()
        {
            while (playerOne.playerScore < 2 && playerTwo.playerScore < 2)
            {
                playerOne.MakeChoice();
                playerTwo.MakeChoice();
                CompareChoices();
            }
            GetWinner();

        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock. The game is best known for its apparence on Big Bang Theory, but it has also become a fun challenge for those learning to code.\n");
        }
        public void PlayerSelection()
        {
            Console.WriteLine("Hello! how many players will we be having, 1 or 2? For a one player game you will be playing against the computer, and for a two player game you will be playing against another human.\n");
            string selection = Console.ReadLine();

            {
                if (selection == "1")
                {
                    Console.WriteLine("Okay you will be playing against Hal, the computer.\n");
                    playerOne = new Human();
                    playerTwo = new Computer();
                }
                else if (selection == "2")
                {
                    Console.WriteLine("Okay you two will take turns making your selections.\n");
                    playerOne = new Human();
                    playerTwo = new Human();
                }
                else
                {
                    Console.WriteLine("I'm sorry you selection wasn't valid, please select either 1 or 2.\n");
                    PlayerSelection();
                }
            }
        }
        public void GameRules()
        {
            Console.WriteLine("So lets go over the rules real quick. The format is a best of three series, first to two wins takes it. As for how to win here is what beats what; scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons spock, spock smashes scissors, scissors decapitates lizard, lizard eats paper, paper disproves spock, spock vaporizes rock, and as it always has rock crushes scissors.\n");

        }
        public void CompareChoices()
        {
            if (playerOne.choice == "rock" && playerTwo.choice == "rock" || playerOne.choice == "paper" && playerTwo.choice == "paper" || playerOne.choice == "scissors" && playerTwo.choice == "scissors" || playerOne.choice == "lizard" && playerTwo.choice == "lizard" || playerOne.choice == "spock" && playerTwo.choice == "spock")
            {
                Console.WriteLine("Tie!\n");
                Console.WriteLine("Please go again\n");

            }
            if (playerOne.choice == "paper" && playerTwo.choice == "rock" || playerOne.choice == "scissors" && playerTwo.choice == "paper" || playerOne.choice == "rock" && playerTwo.choice == "lizard" || playerOne.choice == "lizard" && playerTwo.choice == "spock" || playerOne.choice == "spock" && playerTwo.choice == "scissors" || playerOne.choice == "scissors" && playerTwo.choice == "lizard" || playerOne.choice == "lizard" && playerTwo.choice == "paper" || playerOne.choice == "paper" && playerTwo.choice == "spock" || playerOne.choice == "spock" && playerTwo.choice == "rock" || playerOne.choice == "rock" && playerTwo.choice == "scissors")
            {
                Console.WriteLine("playerOne wins: " + playerOne.choice + " beats " + playerTwo.choice);
                playerOne.playerScore++;
            }
            if (playerOne.choice == "rock" && playerTwo.choice == "paper" || playerOne.choice == "paper" && playerTwo.choice == "scissors" || playerOne.choice == "lizard" && playerTwo.choice == "rock" || playerOne.choice == "spock" && playerTwo.choice == "lizard" || playerOne.choice == "scissors" && playerTwo.choice == "spock" || playerOne.choice == "lizard" && playerTwo.choice == "scissors" || playerOne.choice == "paper" && playerTwo.choice == "lizard" || playerOne.choice == "spock" && playerTwo.choice == "paper" || playerOne.choice == "rock" && playerTwo.choice == "spock" || playerOne.choice == "scissors" && playerTwo.choice == "rock")
            {
                Console.WriteLine("playerTwo wins: " + playerTwo.choice + " beats " + playerOne.choice);
                playerTwo.playerScore++;
            }
        }
        public void GetWinner()
        {
            if (playerOne.playerScore == 2)
            {
                Console.WriteLine("playerOne wins the series: " + playerOne.playerScore + " to " + playerTwo.playerScore);
                EndGame();
            }
            else if (playerTwo.playerScore == 2)
            {
                Console.WriteLine("playerTwo wins the series: " + playerTwo.playerScore + " to " + playerOne.playerScore);
                EndGame();
            }
            else { }
        }
        public void EndGame()
        {

            Console.WriteLine("Would you like to play again? Please enter Y for yes or N for no.");
            string replaySelection = Console.ReadLine();
            string replayChoice = replaySelection.ToUpper();
            {
                if (replayChoice == "Y")
                {
                    GameStart();
                }
                if (replayChoice == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("I'm sorry that isn't one of the options, please try again.");
                    EndGame();
                }
            }
        }
    }


}