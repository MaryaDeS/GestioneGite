using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaGite.Models
{
    internal class Partecipante
    {
     [Key]
        public int PartecipanteID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Address { get; set; } 

        public ICollection<Gita> Gite { get; set; }=new List<Gita>();

    }
}
