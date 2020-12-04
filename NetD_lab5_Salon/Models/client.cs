using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetD_lab5_Salon.Models
{
    public class client
    {
        public int clientID { get; set; }

        public string clientFName { get; set; }

        public string clientLName { get; set; }

        public string clientPhonenumber { get; set; }

        public string clientEmail { get; set; }


        public bool vaildateInfo(string clientFName, string clientLName, string clientPhonenumber, string clientEmail)
        {
            
            if ( string.IsNullOrEmpty(clientFName) || string.IsNullOrEmpty(clientLName) || string.IsNullOrEmpty(clientPhonenumber)||string.IsNullOrEmpty(clientEmail))
            {

                return false;
            }
            else
            {
                long num = 0;
                if (clientPhonenumber.Length == 10 && Int64.TryParse(clientPhonenumber, out num) && clientFName.Length > 1 && clientLName.Length > 1 && IsValidEmail(clientEmail))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
