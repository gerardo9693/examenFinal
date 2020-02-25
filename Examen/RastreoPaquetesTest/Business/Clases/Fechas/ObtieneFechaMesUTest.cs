using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaquetes.Business.Fechas;
using System;

namespace RastreoPaquetesTest.Business.Clases.Fechas
{
    public class ObtieneFechaMesUTest
    {
        [TestClass]
        public class ObtieneDiferenciaMesesUTest
        {
            static DateTime _dtFecha = DateTime.Now;

            [TestMethod]
            public void ObtieneDiferenciaMeses_FechasCorrectas_MesPositivo()
            {
                //Arrange
                DateTime dos = _dtFecha.AddDays(50);
                ObtieneFechaMes SUT = new ObtieneFechaMes(dos, _dtFecha);

                //ACT
                var cResultado = SUT.ObtenerDiferenciaFechas();

                //Asert 
                Assert.AreEqual("+,1 mes", cResultado);
            }

            [TestMethod]
            public void ObtieneDiferenciaMeses_FechasCorrectas_MesNegativo()
            {
                //Arrange
                DateTime dos = _dtFecha.AddDays(50);
                ObtieneFechaMes SUT = new ObtieneFechaMes(_dtFecha, dos);

                //ACT
                var cResultado = SUT.ObtenerDiferenciaFechas();

                //Asert 
                Assert.AreEqual("-,1 mes", cResultado);
            }

            [TestMethod]
            public void ObtieneDiferenciaMeses_FechasCorrectas_MesesNegativos()
            {
                //Arrange
                DateTime dos = _dtFecha.AddDays(60);
                ObtieneFechaMes SUT = new ObtieneFechaMes(_dtFecha, dos);

                //ACT
                var cResultado = SUT.ObtenerDiferenciaFechas();

                //Asert 
                Assert.AreEqual("-,2 meses", cResultado);
            }

            [TestMethod]
            public void ObtieneDiferenciaMeses_FechasCorrectas_MesesPotivos()
            {
                //Arrange
                DateTime dos = _dtFecha.AddDays(60);
                ObtieneFechaMes SUT = new ObtieneFechaMes(dos, _dtFecha);

                //ACT
                var cResultado = SUT.ObtenerDiferenciaFechas();

                //Asert 
                Assert.AreEqual("+,2 meses", cResultado);
            }
        }
    }
}
