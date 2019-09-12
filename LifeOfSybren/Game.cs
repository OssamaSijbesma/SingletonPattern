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

        // Private constructor.
        private Game()
        {
            log.Write("Get scenarios from the seed.");
            scenarios = new GameSeed().GetScenarios();
            log.Write("Start the game.");
            PathControl(1);
        }

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
