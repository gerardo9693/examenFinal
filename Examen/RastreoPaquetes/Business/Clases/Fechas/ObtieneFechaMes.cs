using RastreoPaquetes.Clases;
using System;

namespace RastreoPaquetes.Business.Fechas
{
    public class ObtieneFechaMes : AbstracFactoryObtieneDifFechas
    {
        private TimeSpan DiferenciaMeses;

        public ObtieneFechaMes(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            DiferenciaMeses = _dtFechaEntrega - _dtFechaActual;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaMeses = (DiferenciaMeses.Days / 30);

            if (iDiferenciaMeses != 0)
            {
                return ObtenerMensajeDiferenciaMeses(iDiferenciaMeses);
            }
            else
            {
                return base.ObtenerDiferenciaFechas();
            }
        }

        private string ObtenerMensajeDiferenciaMeses(int _iDiferenciaMeses)
        {
            string cMensaje = _iDiferenciaMeses > 0 ? "+," : "-,";

            int iAbsoluteValor = Math.Abs(_iDiferenciaMeses);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 mes"; break;
                default: cMensaje += iAbsoluteValor + " meses"; break;
            }

            return cMensaje;
        }
    }
}
