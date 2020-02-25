using RastreoPaquetes.Business.Clases.Transportes;
using RastreoPaquetes.Business.PatronBridge;

namespace RastreoPaquetes.Business
{
    public class TransporteBusiness
    {
        private BridgeTransporte bridgeTransport;

        public BridgeTransporte ObtenerTransporte(string _cTransporte)
        {
            string cTransporteMayuscula = _cTransporte.ToUpper();

            switch (cTransporteMayuscula)
            {
                case "BARCO":
                    bridgeTransport = new BridgeTransporte(new ConcreteBarco());
                    break;
                case "TREN":
                    bridgeTransport = new BridgeTransporte(new ConcreteTren());
                    break;
                case "AVION":
                    bridgeTransport = new BridgeTransporte(new ConcreteAvion());
                    break;
            }

            return bridgeTransport;
        }

        public double ObtenerTiempoEntrega(string _cTransporte, double _dDistancia)
        {
            bridgeTransport = ObtenerTransporte(_cTransporte);

            double dTiempoEntrega = bridgeTransport.ObtenerTiempoEntrega(_dDistancia);

            return dTiempoEntrega;
        }
    }
}
