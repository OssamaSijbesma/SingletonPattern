using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LifeOfSybren
{
    public class Log
    {
        // The singleton instance.
        private static readonly Log instance = new Log();
        private StreamWriter logMessages = new StreamWriter("log.txt");
        private int messageCounter = 0;

        // Private constructor.
        private Log() { }

        // Public getter for the singleton instance.
        public static Log Instance => instance;

        public void Write(string message)
        {
            messageCounter++;
            logMessages.WriteLine($"{messageCounter} : {message}");
        }

        public void Close() => logMessages.Close();
    }
}
