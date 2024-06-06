using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp04_Halac.Models;

namespace Tp04_Halac.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Diccionario = ORTWorld.Paquetes;
   
        return View();
    }
    public IActionResult SelectPaquete()
    {
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;


        return View("SelectPaquete");
    }
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion)
    { 
            ViewBag.Destino = Destino-1;        
            ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
            ViewBag.ListaAereos = ORTWorld.ListaAereos;
            ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
            ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
            if(Destino < 0 || Destino >= 10 || Hotel < 0 || Hotel >= 10 || Aereo < 0 || Aereo >= 10  || Excursion < 0 || Excursion >= 10  )
            {
                ViewBag.Error = "Los datos ingresados estan mal";
                return View("SelectPaquete");
            }
            else
            {
                string hotel = ORTWorld.ListaHoteles[Hotel-1];
                string aereo = ORTWorld.ListaAereos[Aereo-1];
                string excursion = ORTWorld.ListaExcursiones[Excursion-1];
                Paquete paquete = new Paquete(hotel, aereo, excursion);
                ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1], paquete);
                ViewBag.Diccionario = ORTWorld.Paquetes;
                return View("Index");
            }      
    }
}
