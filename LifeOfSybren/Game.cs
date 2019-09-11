using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfSybren
{
    public class Game
    {
        // The singleton instance.
        private static Game instance;
        private List<Scenario> scenarios = new List<Scenario>();

        private string choice;

        Log log = Log.Instance;

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

        public bool SetupScenarios()
        {
            Scenario s;

            s = new Scenario(1);
            s.CharacterName = "???";
            s.Dialogue = "Hey, you. You’re finally awake. Walked right into that Yacht Control, same as us, and that thief over there.";
            s.AddChoice("Who am I?", 2);
            scenarios.Add(s);

            s = new Scenario(2);
            s.CharacterName = "???";
            s.Dialogue = "They must have hit you hard. Your studentenpas says your name is Sybren.";
            s.AddChoice("Where am I?", 3);
            scenarios.Add(s);

            s = new Scenario(3);
            s.CharacterName = "???";
            s.Dialogue = "You’re on a prisoner transport to Hattem Central. Those damn Yacht Controllers have taken over all of Hattem.";
            s.AddChoice("Who are you?", 4);
            scenarios.Add(s);

            s = new Scenario(4);
            s.CharacterName = "Gijsbrecht";
            s.Dialogue = "My name is Gijsbrecht. I was on the city’s last defense.";
            s.AddChoice("Cool name, I guess.", 5);
            s.AddChoice("Nice to meet you, 'brother'.", 5);
            s.AddChoice("Haha that can't be a real name.", 5);
            scenarios.Add(s);

            s = new Scenario(5);
            s.Dialogue = "You notice the doors on the prisoner transport aren’t locked properly.";
            s.AddChoice("Do nothing", 6);
            s.AddChoice("Force the door open.", 7);
            scenarios.Add(s);
            
            s = new Scenario(6);
            s.CharacterName = "Gijsbrecht";
            s.Dialogue = "We should escape.";
            s.AddChoice("Escape with Gijsbrecht", 8);
            s.AddChoice("Escape without Gijsbrecht", 9);
            scenarios.Add(s);

            s = new Scenario(7);
            s.CharacterName = "Gijsbrecht";
            s.Dialogue = "Hey, wait for me!";
            s.AddChoice("Escape with Gijsbrecht", 8);
            s.AddChoice("Escape without Gijsbrecht", 9);
            scenarios.Add(s);

            s = new Scenario(8);
            s.Dialogue = "*Epic escape montage*";
            s.AddChoice("", 10);
            scenarios.Add(s);


            s = new Scenario(9);
            s.Dialogue = "Gijsbrecht will remember this.";
            s.AddChoice("", 10);
            scenarios.Add(s);

            s = new Scenario(10);
            s.Dialogue = "Bruh";
            s.AddChoice("", 13);
            scenarios.Add(s);



            return true;
        }

        public void Act(int scenario)
        {
            

            Scenario s = scenarios.Find(x => x.Path == scenario);

            int choice = 0;

            if (s.CharacterName == null)
                Console.WriteLine(s.Dialogue);
            else
                Console.WriteLine(" >> " + s.CharacterName + ": " + s.Dialogue);
            
            if (s.Choices[0] == "")
            {
                Console.ReadLine();
                Act(s.ChoicePaths[0]);
            }
            else
            {
                for (int i = 0; i < s.GetSize(); i++)
                    Console.WriteLine(" " + ++i + ") " + s.Choices[--i]);

                Console.Write(" >  ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice > 0 && choice <= s.GetSize())
                    Act(s.ChoicePaths[--choice]);
                else
                    Act(scenario);
            }

        }

        public void GameOver()
        {
            Console.WriteLine("At your funeral, they play songs out of your worst spotify playlist.");
            Console.WriteLine("Better luck next time.");
            Console.WriteLine("Press 'enter' to try again.");
        }
    }
}
