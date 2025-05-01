using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamdad.WinForm.Inheritance
{
    public enum MotorcycleKind
    {
        Race,
        Scooter
    }
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public MotorcycleKind Kind { get; set; }

    }
}
