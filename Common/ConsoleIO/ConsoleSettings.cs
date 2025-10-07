using System;
using System.Text;

namespace Common.ConsoleIO
{
    public static class ConsoleSettings
    {
        public static void SetConsoleParam()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
        }
    }
}