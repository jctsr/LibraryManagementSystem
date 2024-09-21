using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    internal class CheckEmail
    {
        public string? Email { get; set; }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);

                return addr.Address == email;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
