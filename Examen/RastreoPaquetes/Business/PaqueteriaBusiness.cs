using RastreoPaquetes.Business.Clases.Diccionarios;
using RastreoPaquetes.Business.Clases.Paqueterias;
using RastreoPaquetes.Business.PatronBridge;
using System;
using System.Collections.Generic;

namespace RastreoPaquetes.Business
{
    public class PaqueteriaBusiness
    {
        private BridgePaqueteria paqueteria;

        public BridgePaqueteria ElegirPaqueteria(string _cPaqueteria)
        {
            string cPaqueteria = _cPaqueteria;

            switch (cPaqueteria)
            {
                case "DHL": 
                        paqueteria = new BridgePaqueteria(new PaqueteriaDHL()); 
                    break;
                case "ESTAFETA": 
                        paqueteria = new BridgePaqueteria(new PaqueteriaEstafeta()); 
                    break;
                case "FEDEX": 
                        paqueteria = new BridgePaqueteria(new PaqueteriaFedex()); 
                    break;
                default: 
                        throw new Exception
                        ($"La Paquetería: {_cPaqueteria} no se encuentra registrada en nuestra red de distribución.");
            }

            return paqueteria;
        }

        public string ObtenerCostoMasEconomico(double _dDistancia, string _cTransporte, string _cPaqueteria, double dCostoAnterior)
        {

            foreach (var item in PaqueteriaDiccionary.dcPaqueterias)
            {
                try
                {
                    if (item.Value != _cPaqueteria)
                    {
                        var paqueteria = ElegirPaqueteria(item.Value);

                        double dCosto = paqueteria.ObtenerCostoPedido(_cTransporte, _dDistancia);

                        if (dCostoAnterior > dCosto)
                        {
                            return $"Si lo hubieras pedido en la paqueteria {item.Value}, te hubiera costado {(dCostoAnterior - dCosto)}\n";
                        }

                    }
                }
                catch (Exception e) 
                {
                    throw new ArgumentException("Ha ocurrido un error favor de verificar: " + e.ToString());
                }
            }

            return null;
        }
    }
}
