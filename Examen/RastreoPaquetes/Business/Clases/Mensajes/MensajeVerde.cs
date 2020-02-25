using RastreoPaquetes.Interfaces;
using System;

namespace RastreoPaquetes.Business.Clases.Mensajes
{
    public class MensajeVerde :IMensaje
    {
        public void MuestraMensaje(string cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cMensaje);
        }
    }
}
