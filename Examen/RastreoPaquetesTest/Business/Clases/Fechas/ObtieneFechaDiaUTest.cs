using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaquetes.Business.Clases.Fechas;
using System;

namespace RastreoPaquetesTest.Business.Clases.Fechas
{
    public class ObtieneFechaDiaUTest
    {
        static DateTime _dias = DateTime.Now;

        [TestMethod]
        public void ObtieneDiferenciaDias_FechasCorrectas_DiaPositivo()
        {
            //Arrange
            DateTime dos = _dias.AddDays(1);
            ObtieneFechaDia SUT = new ObtieneFechaDia(dos, _dias);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,1 día", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaDias_FechasCorrectas_DiaNegativo()
        {
            //Arrange
            DateTime dos = _dias.AddDays(1);
            ObtieneFechaDia SUT = new ObtieneFechaDia(_dias, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,1 día", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaDias_FechasCorrectas_DiasNegativos()
        {
            //Arrange
            DateTime dos = _dias.AddDays(10);
            ObtieneFechaDia SUT = new ObtieneFechaDia(_dias, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,10 días", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaDias_FechasCorrectas_DiasPotivos()
        {
            //Arrange
            DateTime dos = _dias.AddDays(10);
            ObtieneFechaDia SUT = new ObtieneFechaDia(dos, _dias);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,10 días", cResultado);
        }
    }
}
