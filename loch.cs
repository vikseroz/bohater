 Console.Write("Podaj punkty życia bohatera: ");
        int hp = int.Parse(Console.ReadLine());

        Console.Write("Czy bohater ma klucz? (true/false): ");
        bool maKlucz = bool.Parse(Console.ReadLine());

        Console.Write("Czy bohater zna hasło? (true/false): ");
        bool znaHaslo = bool.Parse(Console.ReadLine());

        Console.WriteLine(); // Pusta linia dla czytelności

        // 2. Logika sprawdzania warunków wejścia do lochu
        if (hp <= 0)
        {
            Console.WriteLine("Bohater nie może wejść — nie żyje.");
        }
        else if (maKlucz || znaHaslo)
        {
            Console.WriteLine("Bohater może wejść do lochu.");
        }
        else
        {
            Console.WriteLine("Bohater nie może wejść — nie ma sposobu otwarcia drzwi.");
        }