using RastreoPaquetes.Business.PatronBridge;
using RastreoPaquetes.Business.Validaciones;
using RastreoPaquetes.Interfaces;

namespace RastreoPaquetes.Business.Clases.Paqueterias
{
    public class PaqueteriaEstafeta : IPaqueteria
    {
        private BridgeTransporte TransporteEnvio;
        private double frecuenciaUtilidad = 60;
        ValidadorTransporteEstafeta validar = new ValidadorTransporteEstafeta();

        public double ObtenerCostoPedido(string transporte, double _dDistancia)
        {
            validar.ValidarTransporte(transporte);

            double dCosto = TransporteEnvio.ObtenerCostoEnvio(frecuenciaUtilidad, _dDistancia);

            return dCosto;
        }

        public double ObtenerTiempoEntrega(double _dDistancia)
        {
            double dHoras = TransporteEnvio.ObtenerTiempoEntrega(_dDistancia);

            return dHoras;
        }
    }
}
