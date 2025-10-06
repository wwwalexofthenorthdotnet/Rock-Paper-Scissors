using System.Security.Cryptography.X509Certificates;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false, validHand = false;
            string handChoice;
            string gameChoice;
            int playerChoice = 0, botChoice, outcome;
            int botWins = 0, playerWins = 0, ties = 0;

            Random generator = new Random();

            new Thread(() => BGM()).Start();
            
            Console.WriteLine("Welcome to Alex's Sentient Rock Paper Scissors Lizard Spock!");

            while (!done)
            {
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
                    gameChoice = "";
                    Console.Clear();

                    while (!validHand)
                    {
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

                        

                    }
                }



            }


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
