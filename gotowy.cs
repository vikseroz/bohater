
        Console.Write("ile bohater ma życia: ");
        int hp = int.Parse(Console.ReadLine());

        Console.Write("ile ma mikstur: ");
        int mikstury = int.Parse(Console.ReadLine());

        Console.Write("Czy bohater ma klucz? (true/false): ");
        bool maKlucz = bool.Parse(Console.ReadLine());

        Console.Write("Czy bohater ma mapę? (true/false): ");
        bool maMape = bool.Parse(Console.ReadLine());
        Console.WriteLine();

    
        bool zyje = hp > 0;
        bool maPelneZdrowie = hp == 100;
        bool wymagaLeczenia = !maPelneZdrowie;
        
        bool maZaopatrzenie = mikstury >= 1;
        bool maPrzedmiotNawigacyjny = maKlucz || maMape;
        
        
        bool gotowyDoWyprawy = zyje && maZaopatrzenie && maPrzedmiotNawigacyjny;

        
        Console.WriteLine("--- STATUS BOHATERA ---");
        Console.WriteLine($"Żyje: {zyje}");
        Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");
        Console.WriteLine($"Wymaga leczenia: {wymagaLeczenia}");
        Console.WriteLine($"Ma zaopatrzenie: {maZaopatrzenie}");
        Console.WriteLine($"Ma klucz lub mapę (Przedmiot nawigacyjny): {maPrzedmiotNawigacyjny}");
        Console.WriteLine($"Gotowy do wyprawy: {gotowyDoWyprawy}");