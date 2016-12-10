using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    public class Brand
    {
        #region Proporties
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } // Brand of the Keyboard : Logitech, Insignia, Apple etc
        [Required]
        public string Country { get; set; }
        public string FullName { get; set; }


        public virtual ICollection<Keyboard> Keyboards { get; set; }
        

        #endregion
    }
}
