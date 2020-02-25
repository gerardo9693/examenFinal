using RastreoPaquetes.Interfaces;

namespace RastreoPaquetes.Business.PatronBridge
{
    public class BridgePaqueteria
    {
        protected IPaqueteria Paqueteria;

        public BridgePaqueteria(IPaqueteria _paqueteria)
        {
            Paqueteria = _paqueteria;
        }
        public virtual double ObtenerCostoPedido(string _transporte, double _dDistancia)
        {
            return Paqueteria.ObtenerCostoPedido(_transporte, _dDistancia);
        }

        public virtual double ObtenerTiempoEntrega(string _transporte, double _dDistancia)
        {
            return Paqueteria.ObtenerTiempoEntrega(_dDistancia);
        }
    }
}
