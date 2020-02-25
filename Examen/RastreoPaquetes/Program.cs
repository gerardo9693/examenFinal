using RastreoPaquetes.Business;
using RastreoPaquetes.DTO;
using RastreoPaquetes.Service;
using System;
using System.Collections.Generic;

namespace RastreoPaquetes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bienvenido a la tienda en linea Ali Express";

            VerificarEntregaPedido();

            Console.ReadKey();
        }

        public static void VerificarEntregaPedido()
        {
            PaqueteriaService srvPaqueteria = new PaqueteriaService(new PaqueteriaBusiness());
            FechasService srvFechas = new FechasService(new FechasBusiness());
            MensajesService msgSrv = new MensajesService(new MensajeBusiness());
            ArchivoService srvArchivo = new ArchivoService(new ArchivoBusiness());

            try
            {
                List<DatosEnvioDTO> datos = srvArchivo.ObtenerPedidos();

               
                foreach (var lista in datos)
                {
                    try
                    {
                        DateTime FechaHoy = DateTime.Now;
                        double dDistancia = lista.dDistancia;
                        string cTransporte = lista.cTransporte;
                        string cPaqueteria = lista.cPaqueteria;
                        DateTime dtFechaPedido = lista.dtFechaPedido;

                        var Paqueteria = srvPaqueteria.ElegirPaqueteria(cPaqueteria);

                        lista.cCostoEnvio = Paqueteria.ObtenerCostoPedido(cTransporte, dDistancia);

                        
                        var HorasEntregarPedido = Paqueteria.ObtenerTiempoEntrega(cTransporte, dDistancia);
                        dtFechaPedido.AddHours(HorasEntregarPedido);

                        var TiempoRestanteEntregaTemp = srvFechas.ObtenerDiferenciaFechas(dtFechaPedido, FechaHoy);
                       
                        lista.PaqueteEntregado = (TiempoRestanteEntregaTemp.Split(',')[0] == "-") ? true : false;

                        
                        lista.cTiempoEntrega = TiempoRestanteEntregaTemp.Split(',')[1];

                        lista.cOpcionEconomica = srvPaqueteria.ObtenerCostoMasEconomico(dDistancia, cTransporte, cPaqueteria, lista.cCostoEnvio);
                    }
                    catch (Exception e)
                    {
                        lista.cError = e.Message;
                    }
                }

                msgSrv.PrintResultado(datos);
            }
            catch (Exception e)
            {
                msgSrv.MuestraError(e.Message);
            }
        }
    }
}
