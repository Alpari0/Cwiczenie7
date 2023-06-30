using System;


    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            Console.Write("Podaj współrzędną x pierwszego punktu: ");
            while (!double.TryParse(Console.ReadLine(), out x1))
            {
                Console.WriteLine("Niepoprawna wartość. Podaj liczbę rzeczywistą.");
                Console.Write("Podaj współrzędną x pierwszego punktu: ");
            }
            Console.Write("Podaj współrzędną y pierwszego punktu: ");
            while (!double.TryParse(Console.ReadLine(), out y1))
            {
                Console.WriteLine("Niepoprawna wartość. Podaj liczbę rzeczywistą.");
                Console.Write("Podaj współrzędną y pierwszego punktu: ");
            }
            Console.Write("Podaj współrzędną x drugiego punktu: ");
            while (!double.TryParse(Console.ReadLine(), out x2))
            {
                Console.WriteLine("Niepoprawna wartość. Podaj liczbę rzeczywistą.");
                Console.Write("Podaj współrzędną x drugiego punktu: ");
            }
            Console.Write("Podaj współrzędną y drugiego punktu: ");
            while (!double.TryParse(Console.ReadLine(), out y2))
            {
                Console.WriteLine("Niepoprawna wartość. Podaj liczbę rzeczywistą.");
                Console.Write("Podaj współrzędną y drugiego punktu: ");
            }

            double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);
            Console.WriteLine("Długość odcinka wynosi: {0}", dlugosc);
        }

        static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }