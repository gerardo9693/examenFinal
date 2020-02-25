using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaquetes.Business.Clases.Fechas;
using System;

namespace RastreoPaquetesTest.Business.Clases.Fechas
{
    public class ObtieneFechaMinutoUTest
    {
        static DateTime _minutos = DateTime.Now;

        [TestMethod]
        public void ObtieneDiferenciaMinutos_FechasCorrectas_MinutoPositivo()
        {
            //Arrange
            DateTime _Difminutos = _minutos.AddMinutes(1);
            ObtieneFechaMinuto SUT = new ObtieneFechaMinuto(_Difminutos, _minutos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,1 minuto", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaMinutos_FechasCorrectas_MinutoNegativo()
        {
            //Arrange
            DateTime _Difminutos = _minutos.AddMinutes(1);
            ObtieneFechaMinuto SUT = new ObtieneFechaMinuto(_minutos, _Difminutos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,1 minuto", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaMinutos_FechasCorrectas_MinutosNegativos()
        {
            //Arrange
            DateTime _Difminutos = _minutos.AddMinutes(10);
            ObtieneFechaMinuto SUT = new ObtieneFechaMinuto(_minutos, _Difminutos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,10 minutos", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaMinutos_FechasCorrectas_MinutosPotivos()
        {
            //Arrange
            DateTime _Difminutos = _minutos.AddMinutes(10);
            ObtieneFechaMinuto SUT = new ObtieneFechaMinuto(_Difminutos, _minutos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,10 minutos", cResultado);
        }
    }
}
