using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation;

namespace TransportationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck ford = new Truck();
            Console.WriteLine(ford.GetMPH(65));
            //Console.WriteLine(ford.GetWear(1, 1,1));

            Car fordCar = new Car();
            Console.WriteLine(fordCar.GetMPG(55,11));

            Cycle bmw = new Cycle();
            Console.WriteLine(bmw.GetMPH(200));
        }
    }
}
