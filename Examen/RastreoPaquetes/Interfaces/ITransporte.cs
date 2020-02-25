
namespace RastreoPaquetes.Interfaces
{
    public interface ITransporte
    {
        double ObtenerCostoEnvio(double _FrecUtilidad, double _dDistancia);

        double ObtenerTiempoEntrega(double _dDistancia);
    }
}
