using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Autoservice.UI.Settings;
using Common.ConsoleIO;

namespace Autoservice.UI.Console.IO
{
    public static class DataInputting
    {
        public static int InputOwnerId()
        {
            return Inputting.InputInt32("Ідентифікатор власника", 1, int.MaxValue);
        }
        public static string InputOwnerName()
        {
            return Inputting.InputString("Власник",
                Limitation.OwnerNameMinLength, Limitation.OwnerNameMaxLength);
        }

        public static string InputNumber()
        {
            while (true)
            {
                string number = Inputting.InputString("Номер телефону");
                if (Regex.IsMatch(number, Limitation.PhoneNumberRegex, RegexOptions.IgnoreCase))
                {
                    return number;
                }
                Inputting.OutErrorMessage("Потрібно ввести номер телефону у міжнародному форматі");
            }
        }

        public static string InputEmail()
        {
            return Inputting.InputString("Електронна пошта",
                Limitation.EmailRegex, "Потрібно ввести коректну електронну пошту",
                RegexOptions.IgnoreCase);
        }

        public static string InputAddress()
        {
            return Inputting.InputString("Адреса",
                Limitation.AddressMinLength, Limitation.AddressMaxLength);
        }
    }
}