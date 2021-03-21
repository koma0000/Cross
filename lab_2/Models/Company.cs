using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_2.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Proceeds { get; set; }
        public long Profit { get; set; }
    }

  


}
