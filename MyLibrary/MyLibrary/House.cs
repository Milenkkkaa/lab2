using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class House
    {
        public double Width;
        public double Length;
        public double Height;
        public int Room;
        public int Floor;
        public double Value;
        public double Price;
        public bool HasForniture;


        public double GetCost()
        {
            return (Width * Length) * Price;
        }

        public double Heating()
        {
            return Value * (Width * Length);
        }

    }
}
