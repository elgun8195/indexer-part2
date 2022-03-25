using System;
using System.Collections.Generic;
using System.Text;

namespace Celcius.Models
{
    internal class Celsius
    {
        public double Degree
        {
            get { return Degree; }
            set
            {
                Degree = value;
            }
        }


        public Celsius(double celci)
        {
            Degree = celci;
        }
    }
}
