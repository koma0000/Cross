using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace lab_2.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Proceeds { get; set; }
        public long Profit { get; set; }

        public List<Busines> comm { get; set; } 

        public Company()
        {
            comm = new List<Busines>();
        }

    }

}
