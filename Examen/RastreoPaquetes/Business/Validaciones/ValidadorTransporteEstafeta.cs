using RastreoPaquetes.Business.Clases.Diccionarios;
using RastreoPaquetes.Business.PatronBridge;
using RastreoPaquetes.Interfaces;
using System;

namespace RastreoPaquetes.Business.Validaciones
{
    public class ValidadorTransporteEstafeta : IValidador
    {
        private BridgeTransporte TransporteEnvio;

        public void ValidarTransporte(string _cTransporte)
        {
            bool existe = EstafetaDiccionary.dcTransporte.ContainsValue(_cTransporte.ToUpper());

            if (!existe)
            {
                throw new Exception($"ESTAFETA no ofrece el servicio por {_cTransporte}, te recomendamos cotizar en otra empresa.");
            }

            TransporteEnvio = new TransporteBusiness().ObtenerTransporte(_cTransporte);

        }
    }
}
