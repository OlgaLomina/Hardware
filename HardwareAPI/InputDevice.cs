using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    /// <summary>
    /// Definifion of a InputDevice
    /// </summary> 
    class InputDevice
    {
        #region Proporties
        public string DeviceName { get; set; }

        public string Brand { get; set; } // Brand of the InputDevice : Logitech, Insignia, Apple etc

        public string Model { get; set; } // Model/Series : MK200, MB110LL/B, NS-PNC5011
                                                
        public string SerialNumber { get; set; }  // Serial Number -> S/N : 1508LZ00AR68

        public int Count { get; set; }
        public int OnOff { get; set; } //Status

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

        public void PowerOnOff()
        {
            if (OnOff == 0)
            {
                Console.WriteLine("Power Off");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Power On");
                Console.ReadLine();
            }
        }

        #endregion

    }
}
