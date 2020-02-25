using RastreoPaquetes.Interfaces;
using System;

namespace RastreoPaquetes.Business.Clases.Mensajes
{
    class MensajeAmarillo : IMensaje
    {
        public void MuestraMensaje(string cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(cMensaje);
        }
    }
}
