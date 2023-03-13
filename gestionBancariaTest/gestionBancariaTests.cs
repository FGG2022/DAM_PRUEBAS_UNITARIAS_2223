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
        public void validarMetodoIngreso2()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -1;
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
        public void validarReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -1;
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
        public void validarReintegro2()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -1;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            //Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }

        //Nuevo código examen

        //Primer método para validar que los valores estén entre entre 1 y 100
        [TestMethod]
        public void validarAperturaCuenta()
        {
            // preparación del caso de prueba
            double saldoInicial = 50
            double cantidadApertura1 = 1
            double cantidadApertura100 = 100
            double cantidadApertura30 = 30

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.aperturaCuenta(cantidadApertura100);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(cantidadApertura100, saldoActual, 0.001, "No se ha podido realizar la apertura de la cuenta");

        }


        //Segundo método para validar que los valores que no estén entre entre 1 y 100
        [TestMethod]
        public void validarAperturaCuenta2()
        {
            // preparación del caso de prueba
            double saldoInicial = 50
            double cantidadApertura0 = 0
            double cantidadApertura101 = 101

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.aperturaCuenta(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(cantidadApertura101, saldoActual, 0.001, "No se ha podido realizar la apertura de la cuenta");

        }



    }
}
