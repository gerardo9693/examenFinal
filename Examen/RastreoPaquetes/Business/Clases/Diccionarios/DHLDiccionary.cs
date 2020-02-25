using System.Collections.Generic;

namespace RastreoPaquetes.Business.Clases.Diccionarios
{
    public class DHLDiccionary
    {
        public static Dictionary<int, string> dcTransportes = new Dictionary<int, string>()
        {
            { 1, "AVION" },
            { 2, "BARCO" }
        };
    }
}
