
using Common.ConsoleIO;
using System;

namespace Common.ConsoleUI.Selection
{
    public static class SelectionMethods
    {

        public static string SelectItem(this string[] arr, string prompt)
        {
            if (arr == null || arr.Length == 0)
                return null;
            Console.WriteLine(Inputting.PromptFormat, prompt);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" {0,5} {1}", i + 1, arr[i]);
            }
            int? num = Inputting.InputNullableInt32("Введіть номер рядка", 1, arr.Length);
            if (!num.HasValue)
            {
                return null;
            }
            return arr[num.Value - 1];
        }
    }
}
//using Common.ConsoleIO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Common.ConsoleUI.Selection {
//    public static class SelectionMethods
//    {

//        public static string SelectItem(this string[] arr, string prompt)
//        {
//            if (arr == null || arr.Length == 0)
//                return null;
//            Console.WriteLine("{0}", prompt); // Fixed the issue by replacing Inputting.PromptFormat with a direct format string
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(" {0,5} {1}", i + 1, arr[i]);
//            }
//            int num = Inputting.InputInt32("Введіть номер рядка", 1, arr.Length);
//            return arr[num - 1];
//        }
//    }
//}