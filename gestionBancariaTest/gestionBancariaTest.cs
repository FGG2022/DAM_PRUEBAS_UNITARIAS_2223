using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTest
    {
        // EXAMEN: Métodos para comprobar validez aperturaCuenta

        // Método para probar que no admite valores menores que 1
        [TestMethod]
        public void validarAperturaCuentaSaldoMenorQueUno()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double apertura = 0;
            double saldoActual = 0;
            double saldoEsperado = 0;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.aperturaCuenta(apertura);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }

        // Método para probar que no admite valores mayores que 100
        [TestMethod]
        public void validarAperturaCuentaMayorQueCien()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double apertura = 200;
            double saldoActual = 0;
            double saldoEsperado = 0;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.aperturaCuenta(apertura);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }

        // Método para probar que admite correctamente el valor 1
        [TestMethod]
        public void validarAperturaCuentaSaldoPositivoIgualAUno()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double apertura = 1;
            double saldoActual = 0;
            double saldoEsperado = 1;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.aperturaCuenta(apertura);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }

        // Método para probar que admite correctamente el valor 50
        [TestMethod]
        public void validarAperturaCuentaSaldoPositivoIgualACincuenta()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double apertura = 50;
            double saldoActual = 0;
            double saldoEsperado = 50;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.aperturaCuenta(apertura);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }

        // Método para probar que admite correctamente el valor 100
        [TestMethod]
        public void validarAperturaCuentaSaldoPositivoIgualACien()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double apertura = 100;
            double saldoActual = 0;
            double saldoEsperado = 100;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.aperturaCuenta(apertura);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }

        // ---------------------------------- MÉTODOS DE PRUEBA INICIALES (SIN EXCEPCIONES)--------------------------------
        // Los métodos comentados son los que se han pasado a excepciones en el punto 8 de la práctica.

        [TestMethod]
        public void validarMetodoIngreso()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }

        /*[TestMethod]
        public void ComprobarIngresoNegativo()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -500;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }*/

        [TestMethod]
        public void ComprobarIngresoCero()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 0;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }

        /*[TestMethod]
        public void ComprobarReintegroNegativo()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double retirada = -500;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retirada);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }*/

        /*[TestMethod]
        public void ComprobarReintegroCero()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double retirada = 0;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retirada);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }*/

        /*
        [TestMethod]
        public void ComprobarReintegroSuperiorASaldo()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double retirada = 2000;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retirada);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }*/

        [TestMethod]
        public void ComprobarReintegroIgualASaldo()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double retirada = 1000;
            double saldoActual = 0;
            double saldoEsperado = 0;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retirada);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }

        [TestMethod]
        public void ComprobarReintegroInferiorASaldo()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double retirada = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retirada);

            // Afirmación de la prueba (resultado esperado vs. resultado obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto.");
        }

        // --------------------------------------- MÉTODOS DE PRUEBA CON EXCEPCIONES---------------------------------------

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ComprobarIngresoNegativo()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -500;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarIngreso(ingreso);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ComprobarReintegroNegativo()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double retirada = -500;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retirada);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ComprobarReintegroCero()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double retirada = 0;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retirada);           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ComprobarReintegroSuperiorASaldo()
        {
            // Presentación del caso de prueba
            double saldoInicial = 1000;
            double retirada = 2000;

            // Instancia de objeto de la clase gestionBancaria
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retirada);          
        }
    }
}
