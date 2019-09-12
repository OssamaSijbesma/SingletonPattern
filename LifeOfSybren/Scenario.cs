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

        public int Path() => path;

        public Scenario(int path, string dialogue)
        {
            this.path = path;
            this.dialogue = dialogue;
            
            choices = new string[3];
            paths = new int[3];
        }

        public Scenario(int path, string character, string dialogue) : this(path, dialogue)
        {
            this.character = character;
        }

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

        public void AddChoice(string choice, int path)
        {
            if (!hasChoice)
                hasChoice = !hasChoice;

            choices[size] = choice;
            paths[size] = path;

            size++;
        }

        public void AddDefaultPath(int defaultPath)
        {
            paths[0] = defaultPath;
        }

    }
}
