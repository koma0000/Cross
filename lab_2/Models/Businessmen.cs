using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_2.Models
{
    public class Businessmen
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long age { get; set; }

        public List<Company> Companies { get; set; } = new List<Company>();
    }
}
