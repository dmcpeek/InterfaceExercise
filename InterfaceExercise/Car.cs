using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car() 
        {
        }

        public bool SunRoof { get; set; } = true;
        public int EngineCylinders { get; set; } = 8;
        public string Color { get; set; } = "Blue";
        public int NumberOfWheels { get; set; } = 4;
        public string ManufacturerName { get; set; } = "Duesenberg";
        public string ManufacturerDescription { get; set; } = "It's a Doozy";


        //Car specific
        public bool hastrunk { get; set; } = true;
        public bool iselectric { get; set; } = false;

        public void Drive()
        {
            Console.WriteLine("My Doozy is crusin' down Route 66 in style!");
        }
    }
}
