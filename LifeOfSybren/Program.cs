using System;

namespace LifeOfSybren
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGameActive = true;
            Log log = Log.Instance;
            Console.Title = "Life of Sybren";
            Console.ForegroundColor = ConsoleColor.Cyan;

            log.Write("Program started.");
            Console.WriteLine();
            Console.Write(GameStrings.Intro);
            Console.ReadLine();
            Console.Clear();

            log.Write("Initiate gameloop.");
            while (isGameActive)
            {
                log.Write("Singleton game instance created.");
                Game game = Game.Instance;

                log.Write("Singleton game instance disposed.");
                game.Dispose();
                Console.Clear();
            }

            log.Close();
        }
    }
}
