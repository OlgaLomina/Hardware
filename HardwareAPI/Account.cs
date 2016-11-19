using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public string EmailAddress { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

    }
}
