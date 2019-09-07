using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfSybren
{
    public class Game
    {
        // The singleton instance.
        private static Game instance;

        private string choice;

        // Private constructor.
        private Game() { }

        // Public getter for the singleton instance.
        public static Game Instance
        {
            get
            {
                // If there is no instance create one.
                if (instance == null) instance = new Game();
                return instance;
            }
        }

        public void ActOne()
        {
            Console.WriteLine("You are finally awake");
            Console.WriteLine("1. Sumthing");
            Console.WriteLine("2. Nogwat");
            Console.WriteLine("3. Ding");
            choice = Console.ReadLine().ToLower();
            Console.Clear();
        }

        public void GameOver()
        {
            Console.WriteLine("At your funeral, they play songs out of your worst spotify playlist.");
            Console.WriteLine("Better luck next time.");
            Console.WriteLine("Press 'enter' to try again.");
        }
    }
}
