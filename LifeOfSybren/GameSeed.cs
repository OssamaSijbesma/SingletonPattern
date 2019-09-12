using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfSybren
{
    class GameSeed
    {
        public List<Scenario> scenarios = new List<Scenario>();

        public List<Scenario> GetScenarios()
        {
            Scenario s;
            s = new Scenario(1, "???", "Hey, you. You’re finally awake. Walked right into that Yacht Control, same as us, and that thief over there.");
            s.AddChoice("Who am I?", 2);
            scenarios.Add(s);

            s = new Scenario(2, "???", "They must have hit you hard. Your studentenpas says your name is Sybren.");
            s.AddChoice("Where am I?", 3);
            scenarios.Add(s);

            s = new Scenario(3, "???", "You’re on a prisoner transport to Hattem Central. Those damn Yacht Controllers have taken over all of Hattem.");
            s.AddChoice("Who are you?", 4);
            scenarios.Add(s);

            s = new Scenario(4, "Gijsbrecht", "My name is Gijsbrecht. I was on the city’s last defense.");
            s.AddChoice("Cool name, I guess.", 5);
            s.AddChoice("Nice to meet you, 'brother'.", 5);
            s.AddChoice("Haha that can't be a real name.", 5);
            scenarios.Add(s);

            s = new Scenario(5, "You notice the doors on the prisoner transport aren’t locked properly.");
            s.AddChoice("Do nothing", 6);
            s.AddChoice("Force the door open.", 7);
            scenarios.Add(s);

            s = new Scenario(6, "Gijsbrecht", "We should escape.");
            s.AddChoice("Escape with Gijsbrecht", 8);
            s.AddChoice("Escape without Gijsbrecht", 9);
            scenarios.Add(s);

            s = new Scenario(7, "Gijsbrecht", "Hey, wait for me!");
            s.AddChoice("Escape with Gijsbrecht", 8);
            s.AddChoice("Escape without Gijsbrecht", 9);
            scenarios.Add(s);

            s = new Scenario(8, "*Epic escape montage*");
            s.AddDefaultPath(10);
            scenarios.Add(s);

            s = new Scenario(9, "[Gijsbrecht will remember that.]");
            s.AddDefaultPath(10);
            scenarios.Add(s);
            
            s = new Scenario(10, "While trying to escape you step on a landmine. It explodes.");
            s.AddDefaultPath(0);
            scenarios.Add(s);

            return scenarios;
        }
    }
}
