using RastreoPaquetes.Business;
using System;

namespace RastreoPaquetes.Service
{
    public class FechasService
    {
        private FechasBusiness _fecha;

        public FechasService(FechasBusiness fecha)
        {
            _fecha =fecha;
        }

        public string ObtenerDiferenciaFechas(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            return _fecha.obtenerDiferenciaFechas(_dtFechaEntrega, _dtFechaActual);
        }
    }
}
