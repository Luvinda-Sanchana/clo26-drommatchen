public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Skapa minst 2 spelare
        // Spelare spelare1 = new Spelare("Namn", nummer, "Position" , "Mål");
        // Spelare spelare2 = new Spelare(...);

        Spelare spelare1 = new Spelare("Zombie CL026", 7, "Forward", 3);
        Spelare spelare2 = new Spelare("Erling Haaland", 9, "Forward", 1);
        Spelare spelare3 = new Spelare("Diego Maradona", 10, "Midfielder", 0);
        Spelare spelare4 = new Spelare("Lionel Messi", 5, "Forward", 2);


        // TODO: Skapa 1 match
        // Match match = new Match("Hemmalag", "Bortalag", "Datum");
        Match match = new Match("Legends United", "World XI", "2026-09-18");


        // TODO: Anropa match.Presentera()

        match.Presentera();

        // TODO: Anropa match.AnnounceraMålskytt() med båda spelarna
        match.AnnounceraMålskytt(spelare1);

        match.AnnounceraMålskytt(spelare2);

        match.AnnounceraMålskytt(spelare4);

        // Kontrollera matchhjältar

        Console.WriteLine();

        Console.WriteLine($"ÄrMatchhjälte — {spelare1.Namn}: {match.ÄrMatchhjälte(spelare1)}");

        Console.WriteLine($"ÄrMatchhjälte — {spelare2.Namn}: {match.ÄrMatchhjälte(spelare2)}");

        Console.WriteLine($"ÄrMatchhjälte — {spelare3.Namn}: {match.ÄrMatchhjälte(spelare3)}");

        Console.WriteLine($"ÄrMatchhjälte — {spelare4.Namn}: {match.ÄrMatchhjälte(spelare4)}");

    }
}
