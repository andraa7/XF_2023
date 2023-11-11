using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XF_2023
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 120);
            Car Volvo = new Car("XC-90");
            /*Car Ford = new Car();
            Car Opel = new Car();
            Ford.name = "Mustang";
            Ford.color = "white";
            Ford.year = 2021;
            Ford.maxSpeed = 100;

            Opel.name = "Astra";
            Opel.color = "blue";
            Opel.year = 2020;
            Opel.maxSpeed = 120;*/

            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
            Ford.fullThrottle();
            Console.WriteLine(Opel.name); ;
            Console.WriteLine(Opel.color);
            Console.WriteLine(Opel.year);
            Opel.fullThrottle();
            Console.ReadKey();
        }
    }
}
