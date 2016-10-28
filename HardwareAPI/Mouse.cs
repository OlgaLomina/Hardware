using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    public class Mouse
    {
        #region Proporties
        [Key]
        public int Id { get; set; }
        public string Model { get; set; } // Model/Series : MK200, MB110LL/B, NS-PNC5011
        public string PartNumber { get; set; }  // P/N : 870-000068
        public string SerialNumber { get; set; }  // S/N : 1508LZ00AR68
        public int Wireless { get; set; } // yes = 1, no = 0
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Commentary { get; set; }
        public int Count { get; set; }

       

        #endregion
    }
}
