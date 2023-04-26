using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public Suv()
        {
        }

        public bool SunRoof { get; set; } = true;
        public int EngineCylinders { get; set; } = 4;
        public string Color { get; set; } = "Dark Blue";
        public int NumberOfWheels { get; set; } = 4;
        public string ManufacturerName { get; set; } = "Toyota";
        public string ManufacturerDescription { get; set; } = "Let's Go Places";

        //SUV specific
        public bool AllWheelDrive { get; set; } = true;
        public int SeatingCapacity { get; set; } = 5;

        public void Drive()
        {
            Console.WriteLine("My SUV is driving smoothly down I-25 to Old Colorado City.");
        }
    }
}
