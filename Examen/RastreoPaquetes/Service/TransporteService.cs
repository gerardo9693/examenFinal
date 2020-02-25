using RastreoPaquetes.Business;

namespace RastreoPaquetes.Service
{
    public class TransporteService
    {
        private TransporteBusiness _transporte;

        public double ObtenerTiempoEntregaxTransporte(string _cTransporte, double _dDistancia, string _cPaqueteria)
        {
            return _transporte.ObtenerTiempoEntrega(_cTransporte, _dDistancia);
        }
    }
}
