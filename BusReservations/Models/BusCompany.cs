using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusReservations.Models
{
    public class BusCompany
    {   
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Destination> Destinations { get; set; }
        
        public BusCompany()
        {
            this.Destinations = new List<Destination>();
        }

        public BusCompany(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Destinations = new List<Destination>();
        }
    }
}