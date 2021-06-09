using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {
        //member variables (HAS A)
        public string name;
        public bool isComputer;
        public int humanScore;
        public int oppScore;
        public string chosenHumanGesture;
        public string chosenOppGesture;

        //constructor
        public Player(string name)
        {
            this.name = name;
        }

        //member methods (CANDO)

        public void Fight(string chosenHumanGesture, string chosenOppGesture)
        {
            //player wins
            if (chosenHumanGesture == "Rock" && chosenOppGesture == "Scissors")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            else if (chosenHumanGesture == "Scissors" && chosenOppGesture == "Paper")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            else if (chosenHumanGesture == "Paper" && chosenOppGesture == "Rock")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            else if (chosenHumanGesture == "Rock" && chosenOppGesture == "Lizard")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            else if (chosenHumanGesture == "Lizard" && chosenOppGesture == "Spock")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            else if (chosenHumanGesture == "Spock" && chosenOppGesture == "Scissors")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            else if (chosenHumanGesture == "Scissors" && chosenOppGesture == "Lizard")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            else if (chosenHumanGesture == "Lizard" && chosenOppGesture == "Paper")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            else if (chosenHumanGesture == "Paper" && chosenOppGesture == "Spock")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            else if (chosenHumanGesture == "Spock" && chosenOppGesture == "Rock")
            {
                Console.WriteLine("Player Wins!");
                humanScore++;
            }
            //ties
            else if (chosenHumanGesture == "Paper" && chosenOppGesture == "Paper")
            {
                Console.WriteLine("Tie!");
            }
            else if (chosenHumanGesture == "Rock" && chosenOppGesture == "Rock")
            {
                Console.WriteLine("Tie!");
            }
            else if (chosenHumanGesture == "Scissors" && chosenOppGesture == "Scissors")
            {
                Console.WriteLine("Tie!");
            }
            else if (chosenHumanGesture == "Lizard" && chosenOppGesture == "Lizard")
            {
                Console.WriteLine("Tie!");
            }
            else if (chosenHumanGesture == "Spock" && chosenOppGesture == "Spock")
            {
                Console.WriteLine("Tie!");
            }
            //computer wins
            else if (chosenOppGesture == "Spock" && chosenHumanGesture == "Rock")
            {
                Console.WriteLine("Computer Wins!");
                oppScore++;
            }
            
        }

        public void Choose()
        {
            Console.WriteLine("Choose your attack!");
            string response = Console.ReadLine();

            string[] choices = new string[5];
            choices.[0]("Rock");
            choices.[1]("Paper");
            choices.[2]("Scissors");
            choices.[3]("Lizard");
            choices.[4]("Spock");

            if (response == choices.[0])
            {
                chosenHumanGesture += response;
                Console.WriteLine("Player selected Rock!");
                return;
            }

        }
        public void ComputerChoice()
        {
            Random rnd = new Random();
            string[] choices = new string[5];
            choices.[0]("Rock");
            choices.[1]("Paper");
            choices.[2]("Scissors");
            choices.[3]("Lizard");
            choices.[4]("Spock");

        }
    }
    
}
