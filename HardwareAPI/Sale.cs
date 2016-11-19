using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public SaleTypes SaleType { get; set; }

        public int Id { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
