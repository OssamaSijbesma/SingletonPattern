using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfSybren
{
    public class Game
    {
        private static readonly Game instance = new Game();
        private string choice;

        private Game()
        {

        }

        public static Game Instance => instance;

        public void ActOne()
        {
            Console.WriteLine("You are finally awake");
            Console.WriteLine("1. Sumthing");
            Console.WriteLine("2. Nogwat");
            Console.WriteLine("3. Ding");
            choice = Console.ReadLine().ToLower();
            Console.Clear();
        }
    }
}
