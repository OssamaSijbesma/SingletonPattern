using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfSybren
{
    class Scenario
    {
        private int path;
        private int size;
        private string character;
        private string dialogue;
        private string[] choices;
        private int[] paths;
        private bool hasChoice;

        /// <summary>
        /// Public getter for path.
        /// </summary>
        /// <returns>Path of current scenario.</returns>
        public int Path() => path;

        /// <summary>
        /// Constructor to set path and dialogue of scenario.
        /// </summary>
        /// <param name="path">Path number.</param>
        /// <param name="dialogue">Dialogue text.</param>
        public Scenario(int path, string dialogue)
        {
            this.path = path;
            this.dialogue = dialogue;
            
            choices = new string[3];
            paths = new int[3];
        }

        /// <summary>
        /// Constructor to set path, character and dialogue of scenario.
        /// </summary>
        /// <param name="path">Path number.</param>
        /// <param name="character">Character name.</param>
        /// <param name="dialogue">Dialogue text.</param>
        public Scenario(int path, string character, string dialogue) : this(path, dialogue)
        {
            this.character = character;
        }

        /// <summary>
        /// Method to play game by displaying the current scenario.
        /// </summary>
        /// <returns>Call to itself.</returns>
        public int Play()
        {
            Console.WriteLine();

            if (character == null)
                Console.WriteLine($" {dialogue}");
            else
                Console.WriteLine($" >> {character}: {dialogue}");

            if (size == 0)
                return paths[0];

            for (int i = 0; i < size; i++)
                Console.WriteLine($" {++i}) {choices[--i]}");

            Console.Write(" >  ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice > 0 && choice <= size)
                    return paths[--choice];
                else
                    return Play();
            }
            catch (Exception)
            {
                return Play();
            }
        }

        /// <summary>
        /// Method to add a choice/path combination to a scenario.
        /// </summary>
        /// <param name="choice">Text display of choice.</param>
        /// <param name="path">Path to change to based on choice.</param>
        public void AddChoice(string choice, int path)
        {
            if (!hasChoice)
                hasChoice = !hasChoice;

            choices[size] = choice;
            paths[size] = path;

            size++;
        }

        /// <summary>
        /// Method to add a default path to a scenario.
        /// </summary>
        /// <param name="defaultPath">Path to change to.</param>
        public void AddDefaultPath(int defaultPath)
        {
            paths[0] = defaultPath;
        }

    }
}
