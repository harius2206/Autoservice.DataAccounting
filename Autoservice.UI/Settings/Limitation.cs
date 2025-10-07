using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.UI.Settings
{
    internal class Limitation
    {
        public static int OwnerNameMaxLength = 70;
        public static int OwnerNameMinLength = 3;
        public static int EmailMaxLength = 100;
        public static int EmailMinLength = 5;
        public static int AddressMaxLength = 200;
        public static int AddressMinLength = 10;
        public static string PhoneNumberRegex = @"^\+?[1-9]\d{1,14}$"; 
        public static string EmailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
    }
}