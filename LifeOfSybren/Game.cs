using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfSybren
{
    public class Game : IDisposable
    {
        // The singleton instance.
        private static Game instance;
        private List<Scenario> scenarios = new List<Scenario>();

        Log log = Log.Instance;
        
        /// <summary>
        /// Private constructor to retrieve scenarios and start the game with path 1.
        /// </summary>
        private Game()
        {
            log.Write("Get scenarios from the seed.");
            scenarios = new GameSeed().GetScenarios();
            log.Write("Start the game.");
            PathControl(1);
        }
        
        /// <summary>
        /// Public getter for the singleton instance.
        /// </summary>
        public static Game Instance
        {
            get
            {
                // If there is no instance create one.
                if (instance == null) instance = new Game();
                return instance;
            }
        }

        /// <summary>
        /// If path is 0 or 999, it calls the endscreen, otherwise it finds the next scenario.
        /// </summary>
        /// <param name="path">Path number of wanted scenario.</param>
        private void PathControl(int path)
        {
            switch (path)
            {
                case 0:
                    EndScreen(false);
                    break;
                case 999:
                    EndScreen(true);
                    break;
                default:
                    log.Write($"Sybren takes path: {path}");
                    Scenario s = scenarios.Find(x => x.Path() == path);
                    PathControl(s.Play());
                    break;
            }
        }

        /// <summary>
        /// Writes endscreen lines.
        /// </summary>
        /// <param name="isVictorious">Whether the player is victorious or not.</param>
        private void EndScreen(bool isVictorious)
        {
            Console.WriteLine();
            Console.WriteLine((isVictorious) ? GameStrings.Victory : GameStrings.GameOver);
            Console.Write(" ");
            Console.ReadLine();
        }

        public void Dispose()
        {
            instance = null;
        }
    }
}
