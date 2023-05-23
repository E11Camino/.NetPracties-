using System;

namespace Static
{
    internal class Logger2
    {
        public static Logger2 Instance { get; } = new Logger2();

        private Logger2()
        {
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
