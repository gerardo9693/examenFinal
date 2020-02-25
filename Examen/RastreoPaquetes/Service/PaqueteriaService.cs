using RastreoPaquetes.Business;
using RastreoPaquetes.Business.PatronBridge;

namespace RastreoPaquetes.Service
{
    public class PaqueteriaService
    {
        private PaqueteriaBusiness _paqueteria;

        public PaqueteriaService(PaqueteriaBusiness paqueteria)
        {
            _paqueteria = paqueteria;
        }

        public string ObtenerCostoMasEconomico(double _dDistancia, string _cTransporte, string _cPaqueteria, double dCostoAnterior)
        {
            return _paqueteria.ObtenerCostoMasEconomico(_dDistancia, _cTransporte, _cPaqueteria, dCostoAnterior);
        }

        public BridgePaqueteria ElegirPaqueteria(string _cPaqueteria)
        {
            return _paqueteria.ElegirPaqueteria(_cPaqueteria);
        }
    }
}
