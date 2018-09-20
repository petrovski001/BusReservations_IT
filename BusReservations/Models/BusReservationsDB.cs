using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BusReservations.Models
{
    public class BusReservationsDB : DbContext
    {
        public BusReservationsDB() : base("name=BusReservations") { }

        public DbSet<BusCompany> BusCompanies { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        //public DbSet<ApplicationUser> Users { get; set; }
    }
}