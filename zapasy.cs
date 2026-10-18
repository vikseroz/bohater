
        Console.Write("Podaj liczbę racji żywnościowych: ");
        int racje = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę członków drużyny: ");
        int czlonkowie = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę dni wyprawy: ");
        int dni = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int racjeNaGlowe = racje / czlonkowie; // Dzielenie całkowite
        int pozostaleRacje = racje % czlonkowie; // Dzielenie z resztą

        double racjeDziennieDruzyna = (double)racje / dni;
        double racjeDziennieOsoba = (double)racje / (czlonkowie * dni);

    
        Console.WriteLine("--- WYNIKI PODZIAŁU ZAPASÓW ---");
        Console.WriteLine($"Każdy członek drużyny otrzyma: {racjeNaGlowe} pełnych racji");
        Console.WriteLine($"Po równym podziale pozostanie: {pozostaleRacje} racji");
        
    
        Console.WriteLine($"Dziennie na całą drużynę przypadnie: {racjeDziennieDruzyna:F2} racji");
        Console.WriteLine($"Dziennie średnio na jedną osobę przypadnie: {racjeDziennieOsoba:F2} racji");