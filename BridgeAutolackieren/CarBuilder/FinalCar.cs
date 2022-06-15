using BridgeAutolackieren.CarAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeAutolackieren.CarBuilder
{
    public class FinalCar
    {
        private Kar make; //{ get; }
        private IColor color {get;}

        private FinalCar(Kar make, IColor color)
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
            private Kar make;
            private IColor color;
            public FinalCarBuilder SetColor(IColor color)
            {
                this.color = color;
                return this;
            }
            public FinalCarBuilder SetMake(Kar make)
            {
                this.make = make;
                return this;
            }
            public FinalCar Build()
            {
                return new FinalCar(this.make, this.color);
            }
        }
    }
}

