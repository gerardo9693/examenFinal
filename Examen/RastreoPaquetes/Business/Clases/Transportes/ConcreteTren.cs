using RastreoPaquetes.Interfaces;

namespace RastreoPaquetes.Business.Clases.Transportes
{
    public class ConcreteTren : ITransporte
    {
        private int iCostoEnvioKm = 4;
        private int iVelocidadEntrega = 150;

        public double ObtenerCostoEnvio(double _FrecUtilidad, double _dDistancia)
        {
            double dCostoTotal = (iCostoEnvioKm * _dDistancia * (1 + (_FrecUtilidad / 100)));

            return dCostoTotal;
        }

        public double ObtenerTiempoEntrega(double _dDistancia)
        {
            double dHoras = (_dDistancia / iVelocidadEntrega);

            return dHoras;
        }
    }
}
