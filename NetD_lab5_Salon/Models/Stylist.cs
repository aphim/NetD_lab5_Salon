using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetD_lab5_Salon.Models
{
    public class Stylist
    {
        public int stylistID { get; set; }

        public string stylistFName { get; set; }

        public string stylistLName { get; set; }

        public string stylistExt { get; set; }

        public string fullname { get { return this.stylistFName + " " + this.stylistLName; } }

        public bool vaildatestylst(string stylistFName, string stylistLName, string stylistExt)
        {
            if (string.IsNullOrEmpty(stylistFName) || string.IsNullOrEmpty(stylistLName) || string.IsNullOrEmpty(stylistExt))
            {

                return false;
            }
            else
            {
                long num = 0;
                if (stylistExt.Length == 3 && Int64.TryParse(stylistExt, out num) && stylistFName.Length > 1 && stylistLName.Length > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }




    }
}
