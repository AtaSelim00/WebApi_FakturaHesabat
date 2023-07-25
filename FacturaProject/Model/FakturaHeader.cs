using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FacturaProject.Model
{
    public class FakturaHeader
    {
        [Key]
        public int ID { get; set; }
        public DateTime S_tarix { get; set; }
        public int Anbar_no { get; set; }
        public string F_no { get; set; }
    }
}
