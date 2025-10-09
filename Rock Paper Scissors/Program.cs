using System.Security.Cryptography.X509Certificates;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            bool validHand = false, validBet = false;
            string handChoice;
            string gameChoice;
            int playerChoice = 0, botChoice, outcome;
            int botWins = 0, playerWins = 0, ties = 0;
            double bet = 0, totalMoney = 100, peakMoney = 0;

            Random generator = new Random();

            new Thread(() => BGM()).Start();
            
            Console.WriteLine("Welcome to Alex's Sentient Rock Paper Scissors Lizard Spock!");
            validBet = false;
            validHand = false;

            while (!done)
            {
                if (totalMoney > peakMoney)
                    peakMoney = totalMoney;
                
                Console.WriteLine("Play (P) or Quit (Q)?");

                gameChoice = Console.ReadLine();

                if (gameChoice.ToLower() == "quit" || gameChoice.ToLower() == "q")
                {
                    gameChoice = "";
                    Console.Clear();
                    Console.WriteLine("Thanks for playing!");
                    done = true;
                }

                else if (gameChoice.ToLower() == "play" || gameChoice.ToLower() == "p")
                {
                    validBet = false;
                    Console.Clear();

                    while (!validBet)
                    {
                        Console.WriteLine("Time to make a bet! Current BAL: " + totalMoney.ToString("c"));
                        double.TryParse(Console.ReadLine(), out bet);

                        if (bet > totalMoney || bet <= 0)
                            Console.WriteLine("Invalid Bet.");
                        else
                        {
                            Console.WriteLine("You've bet " + bet.ToString("c"));
                            validBet = true;
                        }

                        validHand = false;
                    }



                    while (!validHand)
                    {
                        Console.Clear();
                        
                        Console.WriteLine("Time to make a choice!");
                        Console.WriteLine(" 1. Rock (R) \n 2. Paper (P) \n 3. Scissors (S) \n 4. Lizard (L) \n 5. Spock (SP)");
                        handChoice = Console.ReadLine();

                        if (handChoice.ToLower() == "rock" || handChoice.ToLower() == "r" || handChoice == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose rock!");
                            playerChoice = 0;
                            validHand = true;
                        }
                        else if (handChoice.ToLower() == "paper" || handChoice.ToLower() == "p" || handChoice == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose paper!");
                            playerChoice = 1;
                            validHand = true;
                        }

                        else if (handChoice.ToLower() == "scissors" || handChoice.ToLower() == "s" || handChoice == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose Scissors!");
                            playerChoice = 2;
                            validHand = true;
                        }

                        else if (handChoice.ToLower() == "lizard" || handChoice.ToLower() == "l" || handChoice == "4")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose lizard!");
                            playerChoice = 3;
                            validHand = true;
                        }

                        else if (handChoice.ToLower() == "spock" || handChoice.ToLower() == "sp" || handChoice == "5")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose Spock!");
                            playerChoice = 4;
                            validHand = true;
                        }

                        else
                        {
                            Console.WriteLine("Try Again!");
                            Console.WriteLine();
                        }

                        botChoice = generator.Next(5);

                        if (playerChoice == 0)
                            Rock();
                        else if (playerChoice == 1)
                            Paper();
                        else if (playerChoice == 2)
                            Scissors();
                        else if (playerChoice == 3)
                            Lizard();
                        else if (playerChoice == 4)
                            Spock();

                        Console.WriteLine();


                        if (botChoice == 0)
                            Rock();
                        else if (botChoice == 1)
                            Paper();
                        else if (botChoice == 2)
                            Scissors();
                        else if (botChoice == 3)
                            Lizard();
                        else if (botChoice == 4)
                            Spock();

                        if (playerChoice == botChoice)
                        {
                            Console.WriteLine("It's a tie!");
                            ties = ties + 1;
                        }

                        //Player WIN CONDITIONS

                        else if (playerChoice == 0 && botChoice == 2)
                        {
                            Console.WriteLine("You Win! Rock crushes Scissors.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                            
                        }

                        else if (playerChoice == 0 && botChoice == 3)
                        {
                            Console.WriteLine("You Win! Rock crushes Lizard.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                            
                        }

                        else if (playerChoice == 1 && botChoice == 0)
                        {
                            Console.WriteLine("You Win! Paper covers Rock.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                        }

                        else if (playerChoice == 1 && botChoice == 5)
                        {
                            Console.WriteLine("You Win! Paper disproves Spock.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                        }

                        else if (playerChoice == 2 && botChoice == 1)
                        {
                            Console.WriteLine("You Win! Scissors cuts Paper.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                        }

                        else if (playerChoice == 2 && botChoice == 3)
                        {
                            Console.WriteLine("You Win! Scissors decapitates Lizard.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                        }

                        else if (playerChoice == 3 && botChoice == 4)
                        {
                            Console.WriteLine("You Win! Lizard poisons Spock.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                        }

                        else if (playerChoice == 3 && botChoice == 1)
                        {
                            Console.WriteLine("You Win! Lizard eats Paper.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                        }

                        else if (playerChoice == 4 && botChoice == 2)
                        {
                            Console.WriteLine("You Win! Spock smashes Scissors.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                        }

                        else if (playerChoice == 4 && botChoice == 0)
                        {
                            Console.WriteLine("You Win! Spock vaporizes Rock.");
                            playerWins = playerWins + 1;
                            totalMoney = totalMoney + (bet * 1.2);
                        }

                        //BOT WIN CONDITIONS

                        else if (botChoice == 0 && playerChoice == 2)
                        {
                            Console.WriteLine("You Lose! Rock crushes Scissors.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        else if (botChoice == 0 && playerChoice == 3)
                        {
                            Console.WriteLine("You Lose! Rock crushes Lizard.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        else if (botChoice == 1 && playerChoice == 0)
                        {
                            Console.WriteLine("You Lose! Paper covers Rock.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        else if (botChoice == 1 && playerChoice == 5)
                        {
                            Console.WriteLine("You Lose! Paper disproves Spock.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        else if (botChoice == 2 && playerChoice == 1)
                        {
                            Console.WriteLine("You Lose! Scissors cuts Paper.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        else if (botChoice == 2 && playerChoice == 3)
                        {
                            Console.WriteLine("You Lose! Scissors decapitates Lizard.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        else if (botChoice == 3 && playerChoice == 4)
                        {
                            Console.WriteLine("You Lose! Lizard poisons Spock.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        else if (botChoice == 3 && playerChoice == 1)
                        {
                            Console.WriteLine("You Lose! Lizard eats Paper.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        else if (botChoice == 4 && playerChoice == 2)
                        {
                            Console.WriteLine("You Lose! Spock smashes Scissors.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        else if (botChoice == 4 && playerChoice == 0)
                        {
                            Console.WriteLine("You Lose! Spock vaporizes Rock.");
                            botWins = botWins + 1;
                            totalMoney = totalMoney - (bet);
                        }

                        Console.WriteLine("press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();

                        if (totalMoney <= 0)
                            done = true;

                       
                        gameChoice = "invalid";
                        

                    }
                }



            }
            Console.WriteLine("Game Over! Current Bal: " + totalMoney.ToString("c"));
            Console.WriteLine("Wins: " + playerWins);
            Console.WriteLine("Losses: " + botWins);
            Console.WriteLine("Largest Amount of Money: " + peakMoney.ToString("c"));

        }

        public static void Rock()
        {
            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (____)");
            Console.WriteLine("---.__(___)");
        }

        public static void Paper()
        {

            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)______");
            Console.WriteLine("          ________)");
            Console.WriteLine("          _________)");
            Console.WriteLine("         _________)");
            Console.WriteLine("---.____________)");

        }

        public static void Scissors()
        {
            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)_____");
            Console.WriteLine("          _______)");
            Console.WriteLine("       ___________)");
            Console.WriteLine("      (____)");
            Console.WriteLine("---.__(___)");
        }

        public static void Lizard()
        {
            Console.WriteLine("---.___________");
            Console.WriteLine("        _______)");
            Console.WriteLine("---.________)");
        }

        public static void Spock()
        {
            Console.WriteLine("    ⌠-|");
            Console.WriteLine(" ⌠-|| |   -- --");
            Console.WriteLine(" | || |  / // /");
            Console.WriteLine(" |_|| | /-//=/");
            Console.WriteLine(" | || |/ // /");
            Console.WriteLine(" ( || | // /");
            Console.WriteLine(" |         .______");
            Console.WriteLine(" |         _______)");
            Console.WriteLine("  |       |");

        
        }

        public static void Win()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Thread.Sleep(500);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Thread.Sleep(500);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Thread.Sleep(500);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Thread.Sleep(500);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Thread.Sleep(500);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        public static void Lose()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Thread.Sleep(150);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(150);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Thread.Sleep(150);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(150);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Thread.Sleep(150);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        public static void Notes()
        {
            Console.Beep(262, 500); //C
            Console.Beep(277, 500); //C#
            Console.Beep(294, 500); //D
            Console.Beep(311, 500); //D#
            Console.Beep(330, 500); //E
            Console.Beep(349, 500); //F
            Console.Beep(370, 500); //F#
            Console.Beep(392, 500); //G
            Console.Beep(415, 500); //G#
            Console.Beep(440, 500); //A
            Console.Beep(466, 500); //A#
            Console.Beep(494, 500); //B  
        }

        public static void BGM()
        {

                Console.Beep(330, 500); //E
                Console.Beep(330, 500); //E
                Console.Beep(349, 500); //F
                Console.Beep(392, 500); //G

                Console.Beep(392, 500); //G
                Console.Beep(349, 500); //F
                Console.Beep(330, 500); //E
                Console.Beep(294, 500); //D

                Console.Beep(262, 500); //C
                Console.Beep(262, 500); //C
                Console.Beep(294, 500); //D
                Console.Beep(330, 500); //E
                Console.Beep(330, 500); //E
                Console.Beep(294, 500); //D
                Console.Beep(262, 500); //C

                Console.Beep(330, 500); //E
                Console.Beep(330, 500); //E
                Console.Beep(349, 500); //F
                Console.Beep(392, 500); //G

                Console.Beep(392, 500); //G
                Console.Beep(349, 500); //F
                Console.Beep(330, 500); //E
                Console.Beep(294, 500); //D

                Console.Beep(262, 500); //C
                Console.Beep(262, 500); //C
                Console.Beep(294, 500); //D
                Console.Beep(330, 500); //E
                Console.Beep(294, 500); //D
                Console.Beep(262, 500); //C
                Console.Beep(262, 500); //C

            
        }
    }
}
