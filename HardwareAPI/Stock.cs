using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HardwareAPI
{
    public enum SaleTypes
    {
        Keyboard,
        Mouse,
        Computer
    }
    public static class Stock
    {
        #region Properties

        public static string Name { get; set; }

        public static string Address { get; set; }

        //// Collection of Keyboards
        //public static List<Keyboard> Keyboards { get; set; }

        #endregion

        #region Methods
        public static void AddKeyboard(Keyboard Keyboard)
        {
            using (var model = new HardwareModel())
            {
                model.Keyboards.Add(Keyboard);
                model.SaveChanges();
            }
        }
                
        public static List<Keyboard> GetKeyboards()
        {
            using (var model = new HardwareModel())
            {
                var keyboards = model.Keyboards.Include(k => k.Brand);
                return keyboards.ToList();
            }
        }
        #endregion



    }
}
