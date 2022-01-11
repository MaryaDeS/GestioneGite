using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaGite.Models
{
    internal class Responsabile
    {
        public int ResponsabileID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNumber { get; set; }

        //relazione uno a molti tra gita e responsabile
        public ICollection<Gita> Gite { get; set; }=new List<Gita>();

    }
}
