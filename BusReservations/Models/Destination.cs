using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusReservations.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Price { get; set; }
        public int Distance { get; set; }
        public List<BusCompany> BusCompanies { get; set; }

    }
}