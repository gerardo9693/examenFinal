using System.Collections.Generic;

namespace RastreoPaquetes.Business.Clases.Diccionarios
{
    public class PaqueteriaDiccionary
    {
        public  static Dictionary<int, string> dcPaqueterias = new Dictionary<int, string>()
        {
            { 1, "DHL" },
            { 2, "ESTAFETA" },
            { 3, "FEDEX" }
        };
    }
}
