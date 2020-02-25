using RastreoPaquetes.Clases;
using System;

namespace RastreoPaquetes.Business.Clases.Fechas
{
    public class ObtieneFechaDia : AbstracFactoryObtieneDifFechas
    {
        private TimeSpan DiferenciaDias;


        public ObtieneFechaDia(DateTime _dtFechaEntrega, DateTime _dtFechaActual )
        {
            DiferenciaDias = _dtFechaEntrega - _dtFechaActual;
        }

        public override string ObtenerDiferenciaFechas()
        {

            int iDiferenciaDias = DiferenciaDias.Days;

            if (iDiferenciaDias != 0)
            {
                return ObtenerMensajeDiferenciaDias(iDiferenciaDias);
            }
            else
            {
                return base.ObtenerDiferenciaFechas();
            }
        }

        private string ObtenerMensajeDiferenciaDias(int _iDiferenciaDias)
        {
            string cMensaje = _iDiferenciaDias > 0 ? "+," : "-,";

            int iAbsoluteValor = Math.Abs(_iDiferenciaDias);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 día"; break;
                default: cMensaje += iAbsoluteValor + " días"; break;
            }

            return cMensaje;
        }
    }
}
