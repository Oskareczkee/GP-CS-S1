class GigantycznyQuiz
{
    static void Main()
    {
        //zmienne pomocnicze
        int correctAnswers = 0;
        bool play = true;
        char answer;

        //pytania i odpowiedzi
        string question1 = "Pytanie pierwsze: Który z podanych nie jest językiem programowania?";
        string ans1A = "Java";
        string ans1B = "C#";
        string ans1C = "HTML";
        string ans1D = "Python";
        string question2 = "Pytanie drugie: Który z podanych nie jest systemem operacyjnym?";
        string ans2A = "Windows";
        string ans2B = "Linux";
        string ans2C = "Android";
        string ans2D = "Microsoft";


        Console.WriteLine("Witaj w Gigantycznym Quizie");
        Console.WriteLine(question1);
        Console.WriteLine($" A: {ans1A}\n B: {ans1B}\n C: {ans1C}\n D: {ans1D}");
        Console.WriteLine("Wybierz swoją odpowiedź: ");
        answer = Console.ReadLine()?.ElementAt(0) ?? ' '; //? - odpowiedź z konsoli staje się nullable i unikamy ostrzeżeń, ?? - jeśli jest null wtedy jest przydzielana wartość ' '
        // gracz może wpisać małą i wielką literę, zamieniamy ją na wielką, wtedy nie ma znaczenie czy ktoś wpisał małą czy wielką literkę
        if (char.ToUpper(answer) == 'C')
        {
            correctAnswers++;
            Console.WriteLine("Brawo, gramy dalej! Naciśnij dowolny klawisz");
            Console.ReadKey();
            Console.Clear(); // czyścimy ekran konsoli 
        }
        else
        {
            Console.WriteLine("Przykro mi, poprawna odpowiedź to C. Naciśnij dowolny klawisz");
            play = false; //przy zlej odpowiedzi konczymy program
            Console.ReadKey();
            Console.Clear();
        }


        if (play)
        {
            Console.WriteLine(question2);
            Console.WriteLine($" A: {ans2A}\n B: {ans2B}\n C: {ans2C}\n D: {ans2D}");
            Console.WriteLine("Wybierz swoją odpowiedź: ");
            answer = char.Parse(Console.ReadLine());
            if (char.ToUpper(answer) == 'D')
            {
                correctAnswers++;
                Console.WriteLine("Brawo, gramy dalej! Naciśnij dowolny klawisz");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Przykro mi, poprawna odpowiedź to D. Naciśnij dowolny klawisz");
                play = false;
                Console.ReadKey();
                Console.Clear();
            }
        }


        Console.WriteLine($"Udzieliłeś {correctAnswers} poprawnych odpowiedzi");
        Console.ReadLine();

    }
}

/*
 * Dla ciekawskich:
 * Czy podany sposób będzie efektywny jeśli będziemy chcieli stworzyć quiz z wieloma pytaniami? Czy kod może stać się nieczytelny i trudny do zarządzania
 * Pomyśl lub poszukaj w internecie jak realnie można zbudować taki program, tak aby był prosty w obsłudze i abyśmy mogli uniknąć duplikacji kodu
 */
