using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Tavern
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public string LodgingAvailable { get; set; }
        [Required]
        public string Location { get; set; }
        public List<Booze> Boozes { get; set; } = new List<Booze>();

    }
}