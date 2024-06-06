namespace Tp04_Halac.Models{
public class Paquete
{
    public string Hotel {get; private set;}
    public string Aereo {get; private set;}
    public string Excursion {get; private set;}

    public Paquete(string hotel, string aereo, string excursion)
    {
        Excursion = excursion;
        Aereo = aereo;
        Hotel = hotel;
    }
}
}
