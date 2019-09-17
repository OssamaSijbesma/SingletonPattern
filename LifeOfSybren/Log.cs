using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LifeOfSybren
{
    public class Log
    {
        /// <summary>
        /// Singleton instance.
        /// </summary>
        private static readonly Log instance = new Log();
        private StreamWriter logMessages = new StreamWriter("log.txt");
        private int messageCounter = 0;
        
        /// <summary>
        /// Private constructor
        /// </summary>
        private Log() { }
        
        /// <summary>
        /// Public getter for the singleton instance.
        /// </summary>
        public static Log Instance => instance;

        /// <summary>
        /// Writes log message.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        public void Write(string message)
        {
            messageCounter++;
            logMessages.WriteLine($"{messageCounter} : {message}");
        }

        public void Close() => logMessages.Close();
    }
}
