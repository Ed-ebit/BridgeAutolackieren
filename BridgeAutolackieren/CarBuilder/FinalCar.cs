using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeAutolackieren.CarBuilder
{
    public class FinalCar
    {
        private string make;
        private string color;

        private FinalCar(string make, string color)
        {
            this.make = make;
            this.color = color;
        }   

        public static FinalCarBuilder Builder()
        {
            return new FinalCarBuilder();
        }

        public class FinalCarBuilder
        {
            private string make;
            private string color;
            public FinalCarBuilder SetProperties(string make, string color)
            {
                this.make = make;
                this.color = color;
                return this;
            }
            public FinalCar Build()
            {
                return new FinalCar(this.make, this.color);
            }
        }
    }
}

