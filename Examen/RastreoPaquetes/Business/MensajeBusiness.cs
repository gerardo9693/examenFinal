using RastreoPaquetes.Business.Clases.Mensajes;
using RastreoPaquetes.Business.PatronBridge;
using RastreoPaquetes.Business.Validaciones;
using RastreoPaquetes.DTO;
using System.Collections.Generic;

namespace RastreoPaquetes.Business
{
    public class MensajeBusiness
    {
        private BridgeMensajes msgColor;

        public void ColorMsg(string _color, string _cMensaje)
        {
            switch (_color)
            {
                case "ROJO":
                    msgColor = new BridgeMensajes(new MensajeRojo());
                    break;
                case "VERDE":
                    msgColor = new BridgeMensajes(new MensajeVerde());
                    break;
                case "AMARILLO":
                    msgColor = new BridgeMensajes(new MensajeAmarillo());
                    break;
                default:
                    break;
            }

            msgColor.Print(_cMensaje);
        }

        public void ImprimeMsgPaquete(List<DatosEnvioDTO> _DatosPedido)
        {
            foreach (var lstPedidos in _DatosPedido)
            {
                if (ValidadorMensajeVacio.ValidarMensajeVacio(lstPedidos.cError))
                {
                    if (lstPedidos.PaqueteEntregado)
                    {
                        ImprimirMsgPaqueteEntregado(lstPedidos.cLugarOrigen, lstPedidos.cLugarDestino, lstPedidos.cTiempoEntrega, lstPedidos.cCostoEnvio, lstPedidos.cPaqueteria);
                    }
                    else
                    {
                        ImprimirMsgPaqueteEnCamino(lstPedidos.cLugarOrigen, lstPedidos.cLugarDestino, lstPedidos.cTiempoEntrega, lstPedidos.cCostoEnvio, lstPedidos.cPaqueteria);
                    }

                    ColorMsg("", lstPedidos.cOpcionEconomica);
                }
                else
                {
                    ColorMsg("ROJO", lstPedidos.cError + "\n");
                }
            }
        }

        private void ImprimirMsgPaqueteEntregado(string _cOrigen, string _cDestino, string _cTiempoEntrega, double _cCostoEnvio, string _cPaqueteria)
        {
            string cMensajeEntregado = $"Tu paquete salio de {_cOrigen} y llegó a {_cDestino} hace {_cTiempoEntrega}, tuvo un costo de ${_cCostoEnvio} pesos. Cualquier Reclamación con {_cPaqueteria}.";
            ColorMsg("VERDE", cMensajeEntregado);

        }

        private void ImprimirMsgPaqueteEnCamino(string _cOrigen, string _cDestino, string _cTiempoEntrega, double _cCostoEnvio, string _cPaqueteria)
        {
            string cMensajeNoEntregado = $"Tu paquete ha salido de {_cOrigen} y llegará a {_cDestino} dentro de {_cTiempoEntrega}, tendra un costo de ${_cCostoEnvio} pesos. Cualquier Reclamación con {_cPaqueteria}.";
            ColorMsg("AMARILLO", cMensajeNoEntregado);
        }
    }
}
