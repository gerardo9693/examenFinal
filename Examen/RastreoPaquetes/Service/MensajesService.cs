using RastreoPaquetes.Business;
using RastreoPaquetes.DTO;
using System.Collections.Generic;

namespace RastreoPaquetes.Service
{
    public class MensajesService
    {
        private MensajeBusiness _mensajes;

        public MensajesService(MensajeBusiness mensaje)
        {
            _mensajes = mensaje;
        }

        public void PrintResultado(List<DatosEnvioDTO> _DatosPedido)
        {
            _mensajes.ImprimeMsgPaquete(_DatosPedido);
        }

        public void MuestraError(string _cMensaje)
        {
            _mensajes.ColorMsg("ROJO", _cMensaje);
        }

        public void ImprimeMsgVacio(string _cMensaje)
        {
            _mensajes.ColorMsg("", _cMensaje);
        }
    }
}
