using System.Security.Cryptography.X509Certificates;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string handChoice;

            while (!done)
            {
                BGM();
                Thread.Sleep(1000);
            }

            //Console.WriteLine("Welcome to Alex's Sentient Rock Paper Scissors Lizard Spock!");
            
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
            Console.Beep(262, 500); //C
            Console.Beep(262, 500); //C
            Console.Beep(392, 500); //G
            Console.Beep(392, 500); //G
            Console.Beep(440, 500); //A
            Console.Beep(440, 500); //A
            Console.Beep(392, 500); //G


        }
    }
}
