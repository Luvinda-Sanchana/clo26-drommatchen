public class Spelare
{
    // Privata fält
    private string _namn;
    private int _nummer;
    private string _position;
    private int _mål;

    // Properties — publik get, privat set
    public string Namn
    {
        get { return _namn; }
        private set { _namn = value; }

        // Skapa get och privat set för Namn
    }

    public int Nummer
    {
        get { return _nummer; }
        private set { _nummer = value; }

        // Skapa get och privat set för Nummer
    }

    public string Position
    {
        get { return _position; }
        private set { _position = value; }
        // Skapa get och privat set för Position
    }

    public int Mål
    {
        get { return _mål; }
        private set { _mål = value; }
        // Skapa get och privat set för Mål
    }

    // Konstruktor
    public Spelare(string namn, int nummer, string position, int mål)
    {
        // TODO: tilldela de privata fälten
        _namn = namn;
        _nummer = nummer;
        _position = position;
        _mål = mål;
    }
}
