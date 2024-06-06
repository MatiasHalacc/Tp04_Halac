namespace Tp04_Halac.Models;
public static class ORTWorld
{
    public static List<string> ListaDestinos {get; private set;} = new List<string>{"Madrid","Barcelona","Miami","Las Vegas","Buenos Aires","Kiev","Cordoba","Nueva York","Tokyo","Paris"};
    public static List<string> ListaHoteles {get; private set;} = new List<string>{"Hotel1.jpg","Hotel2.jpg","Hotel3.jpg","Hotel4.jpg","Hotel5.jpg","Hotel6.jpg","Hotel7.jpg","Hotel8.jpg","Hotel9.jpg","Hotel10.jpg"};
    public static List<string> ListaAereos {get; private set;} = new List<string>{"AerolineasArgentinas.jpg", "AirCanada.jpg","BritishAirways.jpg","ElAL.jpg","Iberia.jpg","Israir.jpg","Lan.jpg","Panam.jpg","SingaporeAirlines.jpg","VivaColombia.jpg"};
    public static List<string> ListaExcursiones {get; private set;} = new List<string>{"Emadrid.jpg","Ebarcelona.jpg","Emiami.jpg","Elasvegas.jpg","Ebuenosaires.jpg","Ekiev.jpg","Ecordoba.jpg","Enuevayork.jpg","Etokyo.jpg","Eparis.jpg"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;} = new Dictionary<string, Paquete>();

    
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool Repetido;
        if(Paquetes.Keys.Contains(destinoSeleccionado))
        {
            Repetido = true;
        }
        else
        {
            Repetido = false;
            Paquetes.Add(destinoSeleccionado, paquete);
        }
        return Repetido;
    }
}
