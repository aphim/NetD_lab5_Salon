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



        public int clientID { get; set; }

        public virtual client client { get; set; }

    }
}
