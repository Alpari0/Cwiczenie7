using System;

        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę sekund: ");
            int sekundy;
            while (!int.TryParse(Console.ReadLine(), out sekundy) || sekundy < 0)
            {
                Console.WriteLine("Niepoprawna wartość. Podaj liczbę nieujemną.");
                Console.Write("Podaj liczbę sekund: ");
            }

            FormatujCzas(sekundy);
        }

        static void FormatujCzas(int sekundy)
        {
            int godziny = sekundy / 3600;
            int minuty = (sekundy % 3600) / 60;
            int sek = sekundy % 60;

            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", godziny, minuty, sek);
        }