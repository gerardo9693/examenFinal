using RastreoPaquetes.Business.Clases.Diccionarios;
using RastreoPaquetes.Business.PatronBridge;
using RastreoPaquetes.Interfaces;
using System;

namespace RastreoPaquetes.Business.Validaciones
{
    public class ValidadorTransporteDHL : IValidador
    {
        private BridgeTransporte TransporteEnvio;

        public void ValidarTransporte(string _cTransporte)
        {
            bool lexiste = DHLDiccionary.dcTransportes.ContainsValue(_cTransporte);

            if (!lexiste)
            {
                throw new Exception($"DHL no ofrece el servicio por {_cTransporte}, te recomendamos cotizar en otra empresa.");
            }

            TransporteEnvio = new TransporteBusiness().ObtenerTransporte(_cTransporte);
        }
    }
}
