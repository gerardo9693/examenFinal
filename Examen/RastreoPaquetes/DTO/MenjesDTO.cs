
namespace RastreoPaquetes.DTO
{
    public class MenjesDTO
    {
        //si existe una paqueteria con el mismo servicio pero mas barato
        public string cObcionEconomica { get; set; }

        // si la paqueteria no existe en la red
        public string cPaqueteriaNoExiste { get; set; }

        //si la paqueteria no ofrece el servicio de transporte 
        public string TransporteIncorrecto { get; set; }


    }
}
