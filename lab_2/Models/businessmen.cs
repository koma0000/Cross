using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_2.Models
{
    public class Businessmen
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long Age {get;set;}

        public List<Busines> business { get; set; }

        public Businessmen()
        {
            business = new List<Busines>();
        }

        
    }
}
