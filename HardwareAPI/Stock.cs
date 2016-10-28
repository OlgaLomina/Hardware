using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    public static class Stock
    {
        #region Properties

        public static string Name { get; set; }

        public static string Address { get; set; }

        // Collection of Keyboards
        public static List<Keyboard> Keyboards { get; set; }

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
                
        public static void CreateKeyboards()
        {
            using (var model = new HardwareModel())
            {
                foreach (var keyboard in model.Keyboards)
                {
                    Console.WriteLine("Id: {0}, Model: {1}, SerialNumber: {2}, Price: {3}",
                        keyboard.Id, keyboard.Model, keyboard.SerialNumber, keyboard.Price);
                    //Console.Read();
                }
            }
        }
        #endregion



    }
}
