using RastreoPaquetes.Clases;
using System;

namespace RastreoPaquetes.Business.Clases.Fechas
{
    public class ObtieneFechaMinuto : AbstracFactoryObtieneDifFechas
    {
        private TimeSpan DiferenciaMinutos;

        public ObtieneFechaMinuto(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            DiferenciaMinutos = _dtFechaEntrega - _dtFechaActual;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaMinutos = DiferenciaMinutos.Minutes;

            if (iDiferenciaMinutos != 0)
            {
                return ObtenerMensajeDiferenciaMinutos(iDiferenciaMinutos);
            }
            else
            {
                return "+,justo ahora";
            }
        }

        private string ObtenerMensajeDiferenciaMinutos(int _iDiferenciaMinutos)
        {
            string cMensaje = _iDiferenciaMinutos > 0 ? "+," : "-,";
            int iAbsoluteValor = Math.Abs(_iDiferenciaMinutos);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 minuto"; break;
                default: cMensaje += iAbsoluteValor + " minutos"; break;
            }

            return cMensaje;
        }
    }
}
