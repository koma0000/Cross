using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_2.Models
{
    public class Busines
    {
   
        public long BusinessmenId { get; set; }
        public Businessmen Businessmen { get; set; }

        public long CompanyId { get; set; }
        public Company Companys { get; set; }


    }
}
