using RastreoPaquetes.DTO;
using System;
using System.Collections.Generic;
using System.IO;

namespace RastreoPaquetes.Business
{
    public class ArchivoBusiness
    {
        public List<DatosEnvioDTO> ObtenerDatosArchivo()
        {
            string cRuta = @"..\..\DatosPaquete.txt";
            List<DatosEnvioDTO> lstdatos = new List<DatosEnvioDTO>();

            try
            {
                using (StreamReader sr = new StreamReader(cRuta))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        lstdatos.Add(new DatosEnvioDTO
                        {
                            cLugarOrigen = line.Split(',')[0].Trim(),
                            cLugarDestino = line.Split(',')[1].Trim(),
                            dDistancia = double.Parse(line.Split(',')[2]),
                            cPaqueteria = line.Split(',')[3].Trim(),
                            cTransporte = line.Split(',')[4].Trim(),
                            dtFechaPedido = DateTime.Parse(line.Split(',')[5])
                        });
                    }

                    return lstdatos;
                }
            }
            catch (Exception)
            {
                throw new Exception("El archivo no existe, favor de verificar.");
            }
        }
    }
}
