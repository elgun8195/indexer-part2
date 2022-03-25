using System;
using System.Collections.Generic;
using System.Text;

namespace Celcius.Models
{
    internal class Kelvin
    {        
        public double Degree
        {
            get { return Degree; }
            set
            {
                Degree = value;
            }
        }
        
        
        public Kelvin(double kelvin)
        {
            Degree = kelvin;
        }
    }
}
