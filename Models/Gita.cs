using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaGite.Models
{
    internal class Gita
    {
        public int GitaID { get; set; }
        public DateTime DataPartenza { get; set; }

        //relazione uno a molti tra gita e responsabile
        public int ResponsabileID { get; set; }
        public Responsabile Responsabile { get; set; }


        //relazione uno a molti tra gita ed itinerario
        public int ItinerarioID { get; set; }
        public Itinerario Itinerario { get; set; }


        //relazione molti a molti con i partecipanti
        public ICollection<Partecipante> Partecipanti { get; set; }= new List<Partecipante>();
    }
}
