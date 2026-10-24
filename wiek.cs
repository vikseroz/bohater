
        Console.Write("Podaj swój wiek: ");
        
        if (int.TryParse(Console.ReadLine(), out int wiek))
        {
            if (wiek < 0)
            {
                Console.WriteLine("Niepoprawny wiek.");
            }
            else if (wiek >= 0 && wiek <= 12)
            {
                Console.WriteLine("Dziecko.");
            }
            else if (wiek >= 13 && wiek <= 17)
            {
                Console.WriteLine("Nastolatek.");
            }
            else if (wiek >= 18 && wiek <= 64)
            {
                Console.WriteLine("Osoba dorosła.");
            }
            else // 65 i więcej
            {
                Console.WriteLine("Senior.");
            }
        }
        else
        {
            Console.WriteLine("Wprowadzona wartość nie jest poprawną liczbą całkowitą.");
        }
    