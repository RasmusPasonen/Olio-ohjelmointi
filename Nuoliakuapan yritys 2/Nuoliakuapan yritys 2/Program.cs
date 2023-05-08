string tip = "a";
string back = "b";
int length = 0;
string haluttupituus;

Console.WriteLine("Minkälainen kärki (puu, teräs, timantti) :");
while (tip != "puu" || tip != "teräs" || tip != "timantti")
{
    tip = Console.ReadLine();
    if (tip == "puu" || tip == "timantti" || tip == "teräs")
    {
        break;
    }
}
Console.WriteLine("Minkälainen perä (lehti, kanansulka, kotkansulka) :");
while (back != "lehti" || back != "kanansulka" || back != "kotkansulka")
{
    back = Console.ReadLine();
    if (back == "lehti" || back == "kanansulka" || back == "kotkansulka")
    {
        break;
    }
}
Console.WriteLine("Nuolen pituus (60-100cm) :");
while (length < 60 || length > 100)
{
    haluttupituus = Console.ReadLine();
    if (int.TryParse(haluttupituus, out length) == true && length <= 100 && length >= 60)
    {

        length = Convert.ToInt32(haluttupituus);
        break;
    }
}
Nuoli tilattuNuoli = new Nuoli(tip, back, length);
Console.WriteLine("Nuoli maksaa " + tilattuNuoli.PalautaHinta + " kultaa");



public class Arrow
{

    private string _karki;
    private string _pera;
    private double _pituus;
    private double nuolenhinta;

    public Arrow(string karki, string pera, int pituus)

    {

        _karki = karki;

        _pera = pera;

        _pituus = pituus;

        if (_karki == "puu")
        {

            nuolenhinta += 3;

        }
        if (_karki == "teräs")

        {

            nuolenhinta += 5;

        }
        if (_karki == "timantti")

        {

            nuolenhinta += 50;

        }
        if (_pera == "kanansulka")

        {

            nuolenhinta += 1;

        }
        if (_pera == "kotkansulka")

        {
            nuolenhinta += 5;
        }

        nuolenhinta = nuolenhinta + (_pituus * 0.05);
        return;
    }

    public double PalautaHinta

    {

        get { return nuolenhinta; }
        set { nuolenhinta = value; }
    }

    public string Kärki

    {

        get { return _karki; }
        set { _karki = value; }
    }

    public string Perä

    {

        get { return _pera; }
        set { _pera = value; }
    }

    public double Pituus

    {

        get { return _pituus; }
        set { _pituus = value; }
    }

}