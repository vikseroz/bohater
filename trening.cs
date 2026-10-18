int doswiadczenie = 40;
        int zloto = 50;
        int numerTreningu = 1;

        Console.WriteLine("--- STAN POCZĄTKOWY ---");
        Console.WriteLine($"Doświadczenie: {doswiadczenie}");
        Console.WriteLine($"Złoto: {zloto} sztuk");
        Console.WriteLine($"Numer treningu: {numerTreningu}\n");

        doswiadczenie += 25;       // Użycie += (skrócone dodawanie)
        doswiadczenie *= 2;        // Użycie *= (skrócone mnożenie)
        zloto -= 8;                // Użycie -= (skrócone odejmowanie)
        zloto += 15;               // Dodanie nagrody
        numerTreningu++;          // Użycie ++ (inkrementacja)

        Console.WriteLine("--- STAN KOŃCOWY ---");
        Console.WriteLine($"Doświadczenie: {doswiadczenie} (oczekiwane: 130)");
        Console.WriteLine($"Złoto: {zloto} (oczekiwane: 57)");
        Console.WriteLine($"Numer treningu: {numerTreningu} (oczekiwane: 2)");