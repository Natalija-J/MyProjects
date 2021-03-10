using System;


namespace RockPaperScissors
{
    class Game
    {
        public void Play()
        {
            string inputUser, inputComputer;

            int randomNumber;
            bool playAgain = true;
            Console.WriteLine("Rock, Paper, Scissors! Let's play!");
            Console.WriteLine();
            Console.WriteLine("What is your name:   ");
            string userName = Console.ReadLine();
            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreComputer = 0;

                while (scorePlayer < 3 && scoreComputer < 3)
                {
                    Console.Write("Choose: Rock, Paper or Scissors:     ");
                    inputUser = Console.ReadLine().ToLower();

                    Random random = new Random();
                    randomNumber = random.Next(1, 4);

                    switch (randomNumber)
                    {
                        case 1:
                            inputComputer = "ROCK";
                            Console.WriteLine("Computer chose ROCK!");
                            if (inputUser == "rock")
                            {
                                Console.WriteLine("It's a DRAW!");
                            }
                            else if (inputUser == "scissors")
                            {
                                Console.WriteLine("Computer WON!");
                                scoreComputer++;
                            }
                            else if (inputUser == "paper")
                            {
                                Console.WriteLine("{0} WON!", userName);
                                scorePlayer++;
                            }
                            break;

                        case 2:
                            inputComputer = "PAPER";
                            Console.WriteLine("Computer chose PAPER!");
                            if (inputUser == "paper")
                            {
                                Console.WriteLine("It's a DRAW!");
                            }
                            else if (inputUser == "rock")
                            {
                                Console.WriteLine("Computer WON!");
                                scoreComputer++;
                            }
                            else if (inputUser == "scissors")
                            {
                                Console.WriteLine("{0} WON!", userName);
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputComputer = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS!");
                            if (inputUser == "scissors")
                            {
                                Console.WriteLine("It's a DRAW!");
                            }
                            else if (inputUser == "paper")
                            {
                                Console.WriteLine("Computer WON!");
                                scoreComputer++;
                            }
                            else if (inputUser == "rock")
                            {
                                Console.WriteLine("{0} WINS!", userName);
                                scorePlayer++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;

                    }

                    Console.WriteLine($"SCORES:  {userName}:        {scorePlayer};   Computer:        {scoreComputer}");
                    Console.WriteLine();
                }
                Console.WriteLine();
                
                if (scorePlayer == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Congratulations {0}, You WON!", userName);
                    Console.ResetColor();
                }
                else if (scoreComputer == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Computer WON!");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.Write("Would you like to play again? (y/n)  ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    playAgain = true;
                    Console.Clear();

                }
                else if (answer == "n")
                {
                    playAgain = false;
                }
            }

        }
    }
}
