using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {

        public Truck() 
        {
        }

        public bool SunRoof { get; set; }
        public int EngineCylinders { get; set; } = 8;
        public string Color { get; set; } = "Grey";
        public int NumberOfWheels { get; set; } = 2;
        public string ManufacturerName { get; set; } = "Tesla";
        public string ManufacturerDescription { get; set; } = "The Future is Sustainable";

        //Truck specific
        public bool LiftKit { get; set; } = true;
        public bool FourWheelDrive { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine("My new truck is sloshin' down a muddy road");
        }
    }
}
