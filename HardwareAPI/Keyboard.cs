using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    /// <summary>
    /// Definifion of a Keyboard
    /// </summary> 
    public class Keyboard
    {
        #region Proporties
        [Key]
        public int Id { get; set; }
        public string Model { get; set; } // Model/Series : MK200, MB110LL/B, NS-PNC5011
        public string SerialNumber { get; set; }  // Serial Number -> S/N : 1508LZ00AR68
        public int Wireless { get; set; } // yes = 1, no = 0
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Commentary { get; set; }
        public int Count { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        #endregion

        #region Methods
        public void Sale()
        {
            //Count = Count - 1;
            Count--;
        }

        public void Arrival()
        {
            Count++;
        }

        #endregion

    }
}
