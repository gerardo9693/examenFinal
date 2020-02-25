
namespace RastreoPaquetes.Interfaces
{
    public interface IPaqueteria
    {

        double ObtenerCostoPedido(string transporte, double _dDistancia);

        double ObtenerTiempoEntrega(double _dDistancia);
    }
}
