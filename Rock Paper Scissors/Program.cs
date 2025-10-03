namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                Rock();
                Thread.Sleep(1000);
                Console.Clear();
                Paper();
                Thread.Sleep(1000);
                Console.Clear();
                Scissors();
                Thread.Sleep(1000);
                Console.Clear();
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
    }
}
