using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    class Program
    {

        static void Main(string[] args)
        {
            var device = new Keyboard();
            device.Id = 1;
            device.Model = "MB110LL/B";
            device.SerialNumber = "1508LZ00AR68";
            device.Price = 34.18M;
            device.Count = 10;

            Stock.AddKeyboard(device);

            device = new Keyboard();
            device.Id = 2;
            device.Model = "MK200";
            device.SerialNumber = "6108LZ0034DF";
            device.Price = 29.99M;
            device.Count = 35;

            Stock.AddKeyboard(device);

            Stock.CreateKeyboards();


        }

    }
}

