using RastreoPaquetes.Interfaces;

namespace RastreoPaquetes.Business.PatronBridge
{
    public class BridgeTransporte
    {
        protected ITransporte Transporte;

        public BridgeTransporte(ITransporte _Transporte)
        {
            Transporte = _Transporte;
        }

        public virtual double ObtenerCostoEnvio(double _MargenUtilidad, double _dDistancia)
        {
            return Transporte.ObtenerCostoEnvio(_MargenUtilidad, _dDistancia);
        }

        public virtual double ObtenerTiempoEntrega(double _dDistancia)
        {
            return Transporte.ObtenerTiempoEntrega(_dDistancia);
        }
    }
}
