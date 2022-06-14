using BridgeAutolackieren.CarAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeAutolackieren
{
    public class CarMercedes:Kar
    {
        public override void PaintCar() {
            Console.WriteLine("Mercedes has been painted in Color: " + _color.ApplyColor());
        }
    }
}
