using RastreoPaquetes.Interfaces;

namespace RastreoPaquetes.Business.PatronBridge
{
    public class BridgeMensajes
    {
        protected IMensaje color;

        public BridgeMensajes(IMensaje color)
        {
            this.color = color;
        }

        public virtual void Print(string _cMensaje)
        {
            color.MuestraMensaje(_cMensaje);
        }
    }
}
