using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    internal class PhoneNumberValidator
    {
        public static bool IsValidPhoneNumber(string PhoneNumber)
        {
            string Pattern = @"^(?:\+60|0)[1-9]\d{7,9}$";

            return Regex.IsMatch(PhoneNumber, Pattern);
        }
    }
}
