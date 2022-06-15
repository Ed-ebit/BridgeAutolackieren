using BridgeAutolackieren.CarAbstraction;
using BridgeAutolackieren.ColorImplement;
using BridgeAutolackieren.CarBuilder;

namespace BridgeAutolackieren
{
    class Program
    {
        public static void Main()
        {
            var finalcarbuilder = FinalCar.Builder();
            Console.WriteLine("Bitte Farbe wählen:\n" +
                "1. rot, 2. blau, 3. grün");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    finalcarbuilder.SetColor(new Red());
                    break;
                case "2":
                    finalcarbuilder.SetColor(new Blue());
                    break;
                case "3":
                    finalcarbuilder.SetColor(new Green());
                    break;

                default: 
                    Console.WriteLine("ungültig");
                    break;
            }

            Console.WriteLine("Bitte AutoMarke wählen:\n" +
                "1. Lada, 2. Volvo, 3. Mercedes");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    finalcarbuilder.SetMake(new CarLada());
                    break;
                case "2":
                    finalcarbuilder.SetMake(new CarMercedes());
                    break;
                case "3":
                    finalcarbuilder.SetMake(new CarVolvo());
                    break;

                default:
                    Console.WriteLine("ungültig");
                    break;
            }
            var finalcar = finalcarbuilder.Build();
            Console.WriteLine(" Ihr Auto wird gebaut, \nMarke: "+ finalcar.make.ChosenMake()+
                "\nFarbe: "+finalcar.color.ApplyColor());

        }
    }
}
