using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    static class Stock
    {
        #region Properties

        public static string Name { get; set; }

        public static string Address { get; set; }

        // Collection of Input Devices
        public static List<InputDevice> InputDevices { get; set; }

        #endregion

        #region Constructors
        static Stock()
        {
            InputDevices = new List<InputDevice>();
        }
        #endregion

        #region Methods
        public static void AddInputDevice(InputDevice device)
        {
            InputDevices.Add(device);

        }
                
        public static void CreateInputDevices()
        {
            foreach (var device in InputDevices)
            {
                Console.WriteLine("DeviceName: {0}, Brand: {1}, Model: {2}, SerialNumber: {3}",
                    device.DeviceName, device.Brand, device.Model, device.SerialNumber);
                //Console.Read();

                
            }

        }
        #endregion



    }
}
