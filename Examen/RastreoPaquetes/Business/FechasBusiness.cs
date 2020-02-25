using RastreoPaquetes.Business.Clases.Fechas;
using RastreoPaquetes.Business.Fechas;
using System;

namespace RastreoPaquetes.Business
{
    public class FechasBusiness
    {
        public string obtenerDiferenciaFechas(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            var meses = new ObtieneFechaMes(_dtFechaEntrega, _dtFechaActual);
            var dias = new ObtieneFechaDia(_dtFechaEntrega, _dtFechaActual);
            var horas = new ObtieneFechaHora(_dtFechaEntrega, _dtFechaActual);
            var minutos = new ObtieneFechaMinuto(_dtFechaEntrega, _dtFechaActual);

            meses.NextLevel(dias).NextLevel(horas).NextLevel(minutos);

            string result = meses.ObtenerDiferenciaFechas();

            return result;
        }
    }
}
