namespace BridgeAutolackieren
{
    class Program
    {
        public static void Main()
        {
            IColor color = null;
            Kar car = null;
            Console.WriteLine("Bitte Farbe wählen:\n" +
                "1. rot, 2. blau, 3. grün");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    color = new Red();
                    break;
                case "2":
                    color = new Blue();
                    break;
                case "3":
                    color = new Green();
                    break;

                default: 
                    Console.WriteLine("ungültig");
                    break;
            }

            Console.WriteLine("Bitte Auto wählen:\n" +
                "1. Lada, 2. Volvo, 3. Mercedes");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    car = new CarLada();
                    break;
                case "2":
                    car = new CarVolvo();
                    break;
                case "3":
                    car = new CarMercedes();
                    break;

                default:
                    Console.WriteLine("ungültig");
                    break;
            }
            car._color = color;
            car.PaintCar();

        }
    }
}
