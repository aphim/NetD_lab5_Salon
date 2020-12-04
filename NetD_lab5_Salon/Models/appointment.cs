using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetD_lab5_Salon.Models
{
    public class appointment
    {
        public int appointmentID { get; set; }

        public DateTime appointmentDate { get; set; }


        public int stylistID { get; set; }

        public virtual Stylist stylist{ get; set; }

        public string stylistFName { get; set; }
        public string stylistLName { get; set; }

        public string fullname { get { return this.stylistFName + " " + this.stylistFName; } }

        public int clientID { get; set; }

        public virtual client client { get; set; }

    }
}
