using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FacturaProject.Model
{
    public class FakturaBody
    {
        [Key]
        public int ID { get; set; }
        public int Header_ID { get; set; }
        public string ItemBarcode { get; set; }
        public string Logicalref { get; set; }
        public string Code { get; set; }
        public string ItemName { get; set; }
        public int EdedSayi { get; set; }
        public string Vahid { get; set; }
    }
}
