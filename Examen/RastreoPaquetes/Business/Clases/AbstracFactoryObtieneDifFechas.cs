using RastreoPaquetes.Interfaces;

namespace RastreoPaquetes.Clases
{
    public class AbstracFactoryObtieneDifFechas : IDiferenciaFechas
    {
        private IDiferenciaFechas nextHandler;

        public IDiferenciaFechas NextLevel(IDiferenciaFechas Handler)
        {
            nextHandler = Handler;

            return nextHandler;
        }

        public virtual string ObtenerDiferenciaFechas()
        {
            if (nextHandler != null)
            {
                return nextHandler.ObtenerDiferenciaFechas();
            }
            else
            {
                return null;
            }
        }
    }
}
