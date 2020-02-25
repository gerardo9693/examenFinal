
namespace RastreoPaquetes.Interfaces
{
    public interface IDiferenciaFechas
    {
        IDiferenciaFechas NextLevel(IDiferenciaFechas Handler);

        string ObtenerDiferenciaFechas();
    }
}
