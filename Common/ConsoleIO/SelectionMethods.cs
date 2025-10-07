using System;
using Common.Interfaces;

namespace Common.ConsoleIO
{
    public static class SelectionMethods
    {
        public static IKeyable SelectKeyable(this IKeyable[] objects, string prompt)
        {
            Console.WriteLine(" {0}:", prompt);
            string format = "\t{0,2} - {1}";
            Console.WriteLine(format, 0, "відміна вибору");

            for (int i = 0; i < objects.Length; i++)
            {
                Console.WriteLine(format, i + 1, objects[i].Key);
            }

            int number = Inputting.InputInt32("\n Введіть номер команди", 0, objects.Length);
            if (number == 0)
                return null;

            return objects[number - 1];
        }
    }
}