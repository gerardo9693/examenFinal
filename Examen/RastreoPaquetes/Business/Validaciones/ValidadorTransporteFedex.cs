using RastreoPaquetes.Business.Clases.Diccionarios;
using RastreoPaquetes.Business.PatronBridge;
using RastreoPaquetes.Interfaces;
using System;

namespace RastreoPaquetes.Business.Validaciones
{
    public class ValidaTransporteFedex : IValidador
    {
        private BridgeTransporte TransporteEnvio;

        public void ValidarTransporte(string _cTransporte)
        {
            bool lexiste = FedexDiccionary.dcMedioTransporte.ContainsValue(_cTransporte);

            if (!lexiste)
            {
                throw new Exception($"FEDEX no ofrece el servicio por {_cTransporte}, te recomendamos cotizar en otra empresa.");
            }

            TransporteEnvio = new TransporteBusiness().ObtenerTransporte(_cTransporte);
        }
    }
}
