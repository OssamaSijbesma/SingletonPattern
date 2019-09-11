using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfSybren
{
    class Scenario
    {
        public int Path { get; set; }
        public string CharacterName { get; set; }
        public string Dialogue { get; set; }
        public string[] Choices { get; set; }
        public int[] ChoicePaths { get; set; }
        public int GetSize() { return size; }

        private int size;

        public Scenario(int path)
        {
            Path = path;
            Choices = new string[3];
            ChoicePaths = new int[3];
        }
        
        public void AddChoice(string choice, int path)
        {

            Choices[size] = choice;
            ChoicePaths[size] = path;
            
            size++;

        }

    }
}
