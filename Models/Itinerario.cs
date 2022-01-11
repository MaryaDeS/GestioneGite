﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaGite.Models
{
    internal class Itinerario
    {
        [Key]
        public int ItinerarioID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Durata { get; set; }

        public ICollection<Gita> Gite { get; set; } = new List<Gita>();
    }
}
