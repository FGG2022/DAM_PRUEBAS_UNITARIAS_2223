using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]
           // unit test code [TestMethod]
         public void ValidarMetodoIngresoValido()
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarIngreso_IngresoInvalido()
        {
            // Arrange
            double saldoInicial = 1000;
            double ingreso = -500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            
            cuenta.realizarIngreso(ingreso);
            
            double saldoObtenido = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoInicial, saldoObtenido, "El saldo debe mantenerse igual después de un ingreso inválido.");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ValidarIngreso_IngresoInvalidoLetras()
        {
           
            double saldoInicial = 1000;
            string ingreso = "";
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarIngreso(double.Parse(ingreso));
            
            Assert.ThrowsException<FormatException>(() => cuenta.realizarIngreso(double.Parse(ingreso)));

            double saldoObtenido = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoInicial, saldoObtenido, "El saldo debe mantenerse igual después de un ingreso inválido.");

        }

       [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidarIngreso_IngresoInvalidoNulo()
        {
            {
                // Arrange
                double saldoInicial = 1000;
                gestionBancaria cuenta = new gestionBancaria(saldoInicial);

                cuenta.realizarIngreso(double.Parse(null));

                // Act and Assert
                Assert.ThrowsException<ArgumentNullException>(() => cuenta.realizarIngreso(double.Parse(null)));
            }
        }


        [TestMethod]
        // unit test code [TestMethod]
        public void ValidarMetodoReintegroValido()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarMetodo_ReintegroInvalido()
        {
            // Arrange
            double saldoInicial = 1000;
            double reintegro = -500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(reintegro);

            double saldoObtenido = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoInicial, saldoObtenido, "El saldo debe mantenerse igual después de un ingreso inválido.");
        }

    }

}

