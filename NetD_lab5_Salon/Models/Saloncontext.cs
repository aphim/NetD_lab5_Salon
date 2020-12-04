//Program:      Netd 3202 Lab 5 Salon Webpage
//Created by:   Jacky Yuan
//Date:         Dec 04, 2020
//Purpose:      Basic website for a hair salon
//Change log:   N/A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetD_lab5_Salon.Models
{
    public class Saloncontext : DbContext
    {
        public Saloncontext(DbContextOptions<Saloncontext> options) : base(options)
        {

        }

        public DbSet<appointment> appointment { get; set; }
        public DbSet<client> client { get; set; }
        public DbSet<Stylist> stylist { get; set; }

    }
}
