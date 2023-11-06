class Program
{
    public static void Cwiczenie1()
    {
        string imie = "Oskar";
        int wiek = 20;
        double wzrost = 1.70;
        int numer = 132;

        Console.WriteLine($"Mam na imie {imie}, mam {wiek} lat, mam {wzrost}m wzrostu. Mój ulubiony numer to: {numer}\n");
        Console.WriteLine("Mam na imie {0}, mam {1} lat, mam {2}m wzrostu. Mój ulubiony numer to: {3}", imie, wiek, wzrost, numer);
    }

    public static void Cwiczenie2()
    {
        string UlubionaPiosenka = "Hand of Blood";
        decimal kieszonkowe = 14.99M;
        char litera = 'N';
        bool CzyDojezdzamAutobusem = false;

        Console.WriteLine($"Ulubiona piosenka: {UlubionaPiosenka}");
        Console.WriteLine($"Kieszonkowe: {kieszonkowe:C}");
        Console.WriteLine($"Pierwsza litera nazwiska: {litera}");
        Console.WriteLine($"Dojezdza autobusem: {CzyDojezdzamAutobusem}");

        Console.ReadKey();
    }


    public static void Main()
    {
        Cwiczenie2();
    }
}
