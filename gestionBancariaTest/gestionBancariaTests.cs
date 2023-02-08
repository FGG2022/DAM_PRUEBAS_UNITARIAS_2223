using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]          
            public void validarMetodoIngreso()
            {
                // preparación del caso de prueba
                double saldoInicial = 1000;
                double ingreso = 500;
                double saldoActual = 0;
                double saldoEsperado = 1500;
                gestionBancaria cuenta = new gestionBancaria(saldoInicial);
                // Método a probar
                cuenta.realizarIngreso(ingreso);
                // afirmación de la prueba (valor esperado Vs. Valor obtenido)
                saldoActual = cuenta.obtenerSaldo();
                Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
            }
        [TestMethod]
        public void validarMetodoReintegro()
        {
            double saldoInicial = 1000;
            double reintegro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(reintegro);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "No es correcto");
        }


    }
}
