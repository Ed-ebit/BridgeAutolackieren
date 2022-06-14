using BridgeAutolackieren.CarAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeAutolackieren
{
    public class CarLada : Kar
    {
        public override void PaintCar()
        {
            Console.WriteLine("Lada has been painted in Color: " + _color.ApplyColor());
        }
    }
}
