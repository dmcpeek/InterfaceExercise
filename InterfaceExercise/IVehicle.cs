using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        // MEMBERS in common to SUVs, Trucks, and Cars
        public bool SunRoof { get; set; }
        public int EngineCylinders { get; set; }
        public string Color { get; set;}
        public int NumberOfWheels { get; set; }

        public void Drive();
    }
}
