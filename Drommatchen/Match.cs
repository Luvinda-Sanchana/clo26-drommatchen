public class Match
{
    // Privata fält
    private string _hemmalag;
    private string _bortalag;
    private string _datum;

    // Properties — publik get, privat set
    public string Hemmalag
    {
        get { return _hemmalag; }
        private set { _hemmalag = value; }
        // get och privat set för Hemmalag 
    }

    public string Bortalag
    {
        get { return _bortalag; }
        private set { _bortalag = value; }  
        // get och privat set för Bortalag
    }

    public string Datum
    {
        get { return _datum; }
        private set { _datum = value; } 
        // get och privat set för Datum
    }

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
        _hemmalag = hemmalag;
        _bortalag = bortalag;
        _datum = datum;
        // TODO: tilldela de privata fälten
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        Console.WriteLine($"{Hemmalag} vs {Bortalag} - {Datum}");
        Console.WriteLine();
        // TODO
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        Console.WriteLine($"MÅÅÅL! #{spelare.Nummer} {spelare.Namn} ({spelare.Position})");
        // TODO

    }

        // Kontrollerar om spelaren är matchhjälte
    public bool ÄrMatchhjälte(Spelare spelare)
    {
        return spelare.Mål >= 1;
    }

}

