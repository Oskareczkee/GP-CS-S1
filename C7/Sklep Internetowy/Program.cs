class SklepInternetowy
{
    static void Main()
    {
        double mousePrice = 230f; //zazwyczaj do wszelkich cen używa się zmiennej decimal, jednak użycie floata nie jest bledem
        double headphonesPrice = 500f;
        const string promoCode = "GigaPromo23";
        const double discount = 0.85f; //nasza promocja bedzie wynosila 15% w tym przypadku

        // :C - zamienia na walutę (dodaje do liczby np. PLN)
        //pamiętajcie, że pomiędzy zmienną a :C nie może być żadnej spacji !!, inaczej po prostu nie wydrukuje nam się 
        Console.WriteLine($"Witaj w naszym sklepie internetowym!\n\n"+
                          "Wybierz numer interesującego ciebie przedmiotu:\n" +
                          $"1 - Mysz gamingowa - {mousePrice:C}\n" +
                          $"2 - Słuchawki gamingowe - {headphonesPrice:C}");


        int wybor;
        if (!int.TryParse(Console.ReadLine(), out wybor)) //sprawdzamy czy to co podal uzytkownik jest liczba, jesli nie jest 
        {                                                 //drukujemy komunikat i wylaczamy program
            Console.WriteLine("Niepoprawny wybór");       //kiedy poznamy petle bedzie mozna powrocic do tego programu i napisac go tak, by prosil uzytkownika
            return;                                       //o ponowne wpisanie wartosci
        }

        //jesli uzytkownik wybral myszke lub sluchawki
        if (wybor == 1)
        {
            Console.WriteLine("Doskonaly wybor! Podaj kod promocyjny aby dostac znizke: ");
            string? code = Console.ReadLine(); // ? - typ staje sie nullowalny (nie pojawia sie nam ostrzezenie)
            if (code == promoCode) //jesli ktos wybral myszke i kod jest ok, naliczamy promocje
                Console.WriteLine($"Dziekujemy za kod promocyjny!\nDo zapłaty: {(mousePrice * discount):C}");
            else
                Console.WriteLine($"Niestety podany kod promocyjny jest błędny\nDo zapłaty: {mousePrice:C}");
        }
        else if (wybor==2) //to samo co w myszce, ale wersja dla sluchawek
        {
            Console.WriteLine("Doskonaly wybor! Podaj kod promocyjny aby dostac znizke: ");
            string? code = Console.ReadLine();
            if (code == promoCode)
                Console.WriteLine($"Dziekujemy za kod promocyjny!\nDo zapłaty: {(headphonesPrice * discount):C}");
            else
                Console.WriteLine($"Niestety podany kod promocyjny jest błędny\nDo zapłaty: {headphonesPrice:C}");
        }
        else //jesli wybral cos innego (nie ma tego w sklepie)
            Console.WriteLine("Niestety, wydaje się, że nie ma tego czego szukasz :(");

        Console.ReadKey(); //zeby program od razu sie nie wylaczyl
    }
}
