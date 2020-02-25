using RastreoPaquetes.Business;
using RastreoPaquetes.DTO;
using System.Collections.Generic;

namespace RastreoPaquetes.Service
{
    public class ArchivoService
    {
        private ArchivoBusiness _archivo;

        public ArchivoService(ArchivoBusiness archivo)
        {
            _archivo = archivo;
        }

        public List<DatosEnvioDTO> ObtenerPedidos()
        {
            return _archivo.ObtenerDatosArchivo();
        }
    }
}
