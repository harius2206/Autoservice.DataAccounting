using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.ConsoleIO
{
    public class Inputting
    {
        private static string s_promptFormat = "{0,40}: ";
        private static string s_errorMessageFormat = "\t\t{0}";
        public static string PromptFormat
        {
            get { return s_promptFormat; }
        }
        public static void OutPrompt(string prompt)
        {
            Console.Write(s_promptFormat, prompt);
        }

        public static void OutErrorMessage(string message)
        {
            Console.WriteLine(s_errorMessageFormat, message);
        }

        public static int InputInt32(string prompt)
        {
            while (true)
            {
                OutPrompt(prompt);
                string str = Console.ReadLine();
                int value;
                if (int.TryParse(str, out value))
                {
                    return value;
                }
                OutErrorMessage("Помилка введення цілого числа");
            }
        }

        public static void OutInputtingPrompt()
        {
            Console.WriteLine("\tУвага!!! Заміни значень при введенні:\n" +
                              "\t порожній рядок (<Enter>) - NULL\n" +
                              "\t \"\" - порожній рядок.");
        }

        public static string InputString(string prompt)
        {
            Console.Write(s_promptFormat, prompt);
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            if (str == "\"\"")
            {
                return "";
            }
            str = str.Trim();
            return str;
        }

        public static string InputString(string prompt, int minLength, int maxLength)
        {
            while (true)
            {
                string str = InputString(prompt);
                if (str == null || (minLength <= str.Length && str.Length <= maxLength))
                {
                    return str;
                }
                OutErrorMessage(string.Format("\t\tпотрібно ввести від {0} до {1} символів", minLength, maxLength));
            }
        }

        public static string InputString(string prompt, string pattern, string errorMessage, RegexOptions options = RegexOptions.None)
        {
            while (true)
            {
                string str = InputString(prompt);
                if (str == null)
                {
                    return null;
                }
                if (Regex.IsMatch(str, pattern, options))
                {
                    return str;
                }
                OutErrorMessage(errorMessage);
            }
        }

        public static string InputText(string prompt)
        {
            Console.WriteLine(prompt);
            StringBuilder text = new StringBuilder();
            string line;
            while (true)
            {
                line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    break;
                }
                text.AppendLine(line.Trim());
            }
            return text.ToString().Trim();
        }

        public static double? InputNullableDouble(string prompt)
        {
            while (true)
            {
                OutPrompt(prompt);
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    return null;
                }
                try
                {
                    return Convert.ToDouble(str);
                }
                catch (Exception)
                {
                    OutErrorMessage("\t\tпомилка введення дійсного числа");
                }
            }
        }

        public static int InputInt32(string prompt, int min, int max = int.MaxValue)
        {
            while (true)
            {
                int value = InputInt32(prompt);
                if (min <= value && value <= max)
                {
                    return value;
                }
                OutErrorMessage(string.Format("\tВведіть значення в межах від {0} до {1}", min, max));
            }
        }

        public static double? InputNullableDouble(string prompt, double min, double max = double.MaxValue)
        {
            while (true)
            {
                double? value = InputNullableDouble(prompt);
                if (value == null || (min <= value && value <= max))
                {
                    return value;
                }
                OutErrorMessage(string.Format("\tВведіть значення в межах від {0} до {1}", min, max));
            }
        }

        public static decimal? InputNullableDecimal(string prompt)
        {
            while (true)
            {
                OutPrompt(prompt);
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    return null;
                }
                try
                {
                    return Convert.ToDecimal(str);
                }
                catch (Exception)
                {
                    OutErrorMessage("\t\tпомилка введення десяткового числа");
                }
            }
        }

        public static TimeSpan? InputNullableTimeSpan(string prompt)
        {
            while (true)
            {
                OutPrompt(prompt);
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    return null;
                }
                try
                {
                    return TimeSpan.Parse(str);
                }
                catch (Exception)
                {
                    OutErrorMessage("\t\tпомилка введення інтервалу часу (формат: hh:mm:ss)");
                }
            }
        }
        public static int? InputNullableInt32(string prompt)
        {
            while (true)
            {
                OutPrompt(prompt);
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    return null;
                }
                try
                {
                    return Convert.ToInt32(str);
                }
                catch (Exception)
                {
                    OutErrorMessage("\t\tпомилка введення дійсного числа");
                }
            }
        }

        public static int? InputNullableInt32(string prompt,
            int min, int max = int.MaxValue)
        {

            while (true)
            {
                int? value = InputNullableInt32(prompt);
                if (value == null || min <= value && value <= max)
                {
                    return value;
                }
                OutErrorMessage(string.Format(
                    "\tВведіть значення в межах від {0} до {1}", min, max));
            }
        }
    }
}