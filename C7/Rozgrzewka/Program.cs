static class Rozgrzewka
{
    static void Main()
    {
        Console.WriteLine("Podaj symbol lub liczbę atomową szukanego pierwiastka: ");
        string? dane = Console.ReadLine();

        if (dane == "H" || dane == "1")
            Console.WriteLine("Szukany pierwiastek to -> Wodór");
        else if (dane == "Co" || dane == "27")
            Console.WriteLine("Szukany pierwiastek to -> Kobalt");
        else if (dane == "K" || dane == "19")
            Console.WriteLine("Szukany pierwiastek to -> Potas");
        else if (dane == "Ag" || dane == "47")
            Console.WriteLine("Szukany pierwiastek to -> Srebro");
        else if (dane == "Au" || dane == "79")
            Console.WriteLine("Szukany pierwiastek to -> Złoto");
        else if (dane == "Mg" || dane == "12")
            Console.WriteLine("Szukany pierwiastek to -> Magnez");
        else if (dane == "He" || dane == "2")
            Console.WriteLine("Szukany pierwiastek to -> Hel");
        else
            Console.WriteLine("Nie ma takiego pierwiastka");
        Console.ReadLine();
    }
}

/*
 * Dla ciekawskich:
 * Te instrukcje warunkowe wyglądaą trochę opornie, wyobraźcie sobie zaimplementować w taki sposób całą tablicę pierwiastków, to by dużo kodu wyszło!
 * Zapoznajncie się ze strukturą HashMap i zastanówcie się w jaki sposób jej użycie mogłoby uprościć nasz program
 * Spróbujcie znaleźć przykłady i sami zaimplentować coś podobnego przy użyciu HashMapy
 */
