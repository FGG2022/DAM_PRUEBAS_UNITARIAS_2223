using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTest
    {
        [TestMethod]
        public void validarMetodoIngreso()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria();

            // Método a probar
            cuenta.realizarIngreso();

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }
    }
}
