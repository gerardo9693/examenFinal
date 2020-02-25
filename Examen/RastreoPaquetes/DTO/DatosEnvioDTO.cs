using System;

namespace RastreoPaquetes.DTO
{
    public class DatosEnvioDTO
    {
        public string cLugarOrigen { get; set; }

        public string cLugarDestino { get; set; }

        public string cPaqueteria { get; set; }

        public string cTransporte { get; set; }

        public double dDistancia { get; set; }

        public DateTime dtFechaPedido { get; set; }

        public double cCostoEnvio { get; set; }

        public string cTiempoEntrega { get; set; }

        public bool PaqueteEntregado { get; set; }

        public string cOpcionEconomica { get; set; }

        public string cError { get; set; }

    }
}
