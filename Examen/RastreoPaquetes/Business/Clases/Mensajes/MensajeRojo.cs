using RastreoPaquetes.Interfaces;
using System;
namespace RastreoPaquetes.Business.Clases.Mensajes
{
    class MensajeRojo : IMensaje
    {
        public void MuestraMensaje(string cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(cMensaje);
        }
    }
}
