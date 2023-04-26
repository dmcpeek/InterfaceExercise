using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        // Members in common to all vehicle companies
        public string ManufacturerName { get; set; }
        public string ManufacturerDescription { get; set; }
    }
}
