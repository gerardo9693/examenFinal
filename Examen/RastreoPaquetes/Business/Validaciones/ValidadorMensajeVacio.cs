
namespace RastreoPaquetes.Business.Validaciones
{
    public class ValidadorMensajeVacio
    {
        public static bool ValidarMensajeVacio(string cMensaje)
        {
            if (string.IsNullOrEmpty(cMensaje))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
