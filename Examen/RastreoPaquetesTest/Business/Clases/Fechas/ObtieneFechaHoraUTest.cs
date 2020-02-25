using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaquetes.Business.Clases.Fechas;
using System;

namespace RastreoPaquetesTest.Business.Clases.Fechas
{
    public class ObtieneFechaHoraUTest
    {
        static DateTime _hora = DateTime.Now;

        [TestMethod]
        public void ObtieneDiferenciaHoras_FechasCorrectas_HoraPositiva()
        {
            //Arrange
            DateTime _Otrahora = _hora.AddHours(1);
            ObtieneFechaHora SUT = new ObtieneFechaHora(_Otrahora, _hora);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,1 hora", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaHoras_FechasCorrectas_HoraNegativa()
        {
            //Arrange
            DateTime _Otrahora = _hora.AddHours(1);
            ObtieneFechaHora SUT = new ObtieneFechaHora(_hora, _Otrahora);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,1 hora", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaHoras_FechasCorrectas_HorasNegativas()
        {
            //Arrange
            DateTime _Otrahora = _hora.AddHours(10);
            ObtieneFechaHora SUT = new ObtieneFechaHora(_hora, _Otrahora);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,10 horas", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaHoras_FechasCorrectas_HorasPotivas()
        {
            //Arrange
            DateTime _Otrahora = _hora.AddHours(10);
            ObtieneFechaHora SUT = new ObtieneFechaHora(_Otrahora, _hora);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,10 horas", cResultado);
        }
    }
}
