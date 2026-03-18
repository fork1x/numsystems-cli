using System.Text;

namespace NumSystems
{
    class Program
    {
        static void Setup()
        {
            Console.CursorVisible = false;
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.Title = "Systemy liczbowe - nauka i konwersja";
            
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        static void ChangeWindowSize(int width, int height)
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
        }

        static void ShowBinaryInfo()
        {
            ChangeWindowSize(60, 30);
            Console.Clear();

            Console.WriteLine("       System binarny (dwójkowy) - podstawy");
            Console.WriteLine("====================================================\n");

            Console.WriteLine("1. Czym jest?");
            Console.WriteLine("   To system pozycyjny, którego podstawą jest liczba 2.");
            Console.WriteLine("   Używa tylko dwóch cyfr: 0 i 1.\n");

            Console.WriteLine("2. Dlaczego komputery go używają?");
            Console.WriteLine("   Procesory składają się z miliardów tranzystorów,");
            Console.WriteLine("   które mogą być w dwóch stanach: ");
            Console.WriteLine("   - 0 (brak napięcia / wyłączony)");
            Console.WriteLine("   - 1 (jest napięcie / włączony)\n");

            Console.WriteLine("3. Jednostki:");
            Console.WriteLine("   - 1 BIT: Najmniejsza jednostka (0 lub 1).");
            Console.WriteLine("   - 1 BAJT: To 8 bitów (np. 10100111).");
            Console.WriteLine("     Pozwala zapisać liczby od 0 do 255.\n");

            Console.WriteLine("4. Jak liczyć?");
            Console.WriteLine("   Wartości kolejnych pozycji to potęgi liczby 2:");
            Console.WriteLine("   ... 128 | 64 | 32 | 16 | 8 | 4 | 2 | 1");
            Console.WriteLine("   Przykład: 101 (bin) = (1*4) + (0*2) + (1*1) = 5 (dec)\n");

            Console.WriteLine("====================================================");
            Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu...");
            Console.ReadKey(true);
        }

        static void ShowDecimalInfo()
        {
            ChangeWindowSize(60, 30);
            Console.Clear();

            Console.WriteLine("            System dziesiętny - podstawy");
            Console.WriteLine("====================================================\n");

            Console.WriteLine("1. Czym jest?");
            Console.WriteLine("   To system pozycyjny, którego podstawą jest liczba 10.");
            Console.WriteLine("   Jest to system, którego używamy na co dzień.\n");

            Console.WriteLine("2. Jakie cyfry zawiera?");
            Console.WriteLine("   Używamy dziesięciu cyfr: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9.\n");

            Console.WriteLine("3. Dlaczego go używamy?");
            Console.WriteLine("   Najprawdopodobniej dlatego, że nasi przodkowie ");
            Console.WriteLine("   zaczęli liczyć na dziesięciu palcach u rąk.\n");

            Console.WriteLine("4. Jak liczyć (Wagi pozycji)?");
            Console.WriteLine("   Wartości kolejnych pozycji to potęgi liczby 10:");
            Console.WriteLine("   ... 1000 (tysiące) | 100 (setki) | 10 (dziesiątki) | 1 (jedności)");
            Console.WriteLine("   ");
            Console.WriteLine("   Przykład: 253 (dec) = (2*100) + (5*10) + (3*1)");
            Console.WriteLine("   Czyli: 200 + 50 + 3 = 253\n");

            Console.WriteLine("====================================================");
            Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu...");
            Console.ReadKey(true);
        }

        static void ShowHexInfo()
        {
            ChangeWindowSize(60, 30);
            Console.Clear();

            Console.WriteLine("            System szesnatkowy - podstawy");
            Console.WriteLine("====================================================\n");
            Console.WriteLine("1. Czym jest?");
            Console.WriteLine("   To system pozycyjny o podstawie 16.");
            Console.WriteLine("   Używany głównie w informatyce do zapisu kolorów,");
            Console.WriteLine("   adresów pamięci i adresów MAC.\n");

            Console.WriteLine("2. Jakie znaki zawiera?");
            Console.WriteLine("   Używa 16 znaków: 0-9 oraz liter A-F:");
            Console.WriteLine("   A=10, B=11, C=12, D=13, E=14, F=15\n");

            Console.WriteLine("3. Dlaczego go używamy?");
            Console.WriteLine("   Pozwala na bardzo zwięzły zapis liczb binarnych.");
            Console.WriteLine("   Jeden znak Hex odpowiada dokładnie 4 bitom (pół bajta).\n");

            Console.WriteLine("4. Przykład zapisu:");
            Console.WriteLine("   Kolor biały (RGB): #FFFFFF");
            Console.WriteLine("   Liczba FF (hex) = (15 * 16) + (15 * 1) = 255 (dec)\n");

            Console.WriteLine("5. Wagi pozycji:");
            Console.WriteLine("   ... 4096 (16^3) | 256 (16^2) | 16 (16^1) | 1 (16^0)\n");

            Console.WriteLine("====================================================");
            Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu...");
            Console.ReadKey(true);
        }

        static void Conversion()
        {
            ChangeWindowSize(53, 20);
            Console.Clear();
            Console.WriteLine("         Konwersja liczby dziesiętnej");
            Console.WriteLine(" ===================================================\n");

            Console.Write("Wpisz liczbę całkowitą (0-1000000): ");
            if (!int.TryParse(Console.ReadLine(), out int decimalNumber))
            {
                Console.WriteLine("\nBłąd: To nie jest poprawna liczba!");
            }
            else
            {
                Console.WriteLine($"\nWyniki dla liczby: {decimalNumber}\n");

                string binary = Convert.ToString(decimalNumber, 2);
                string octal = Convert.ToString(decimalNumber, 8);
                string hex = Convert.ToString(decimalNumber, 16).ToUpper();

                Console.WriteLine($"BIN (2):  {binary.PadLeft(8, '0')}");
                Console.WriteLine($"OCT (8):  {octal}");
                Console.WriteLine($"DEC (10): {decimalNumber}");
                Console.WriteLine($"HEX (16): {hex}");
            }

            Console.WriteLine("\n====================================================");
            Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić...");
            Console.ReadKey(true);
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                ChangeWindowSize(52, 11);

                Console.WriteLine("       Wita Cię program o systemach liczbowych");
                Console.WriteLine("         Skorzystaj z menu, by przejść dalej");
                Console.WriteLine(" ===================================================\n");
                Console.WriteLine("1 -> Konwersje na różne systemy liczbowe;");
                Console.WriteLine("2 -> Informacja o systemie binarnym;");
                Console.WriteLine("3 -> Informacja o systemie dziesiętnym;");
                Console.WriteLine("4 -> Informacja o systemie szesnastkowym;");
                Console.WriteLine("5 -> Wyjście z programu;");

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.D1: Conversion();
                        break;

                    case ConsoleKey.D2: ShowBinaryInfo();
                        break;

                    case ConsoleKey.D3: ShowDecimalInfo();
                        break;

                    case ConsoleKey.D4: ShowHexInfo();
                        break;

                    case ConsoleKey.D5 or ConsoleKey.Escape: return;
                }
            }
        }

        static void Main(string[] args)
        {
            Setup();
            Menu();
        }
    }
}