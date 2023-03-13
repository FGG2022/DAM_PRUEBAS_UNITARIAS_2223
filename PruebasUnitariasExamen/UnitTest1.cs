using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace PruebasUnitariasExamen
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AperturaCuentaValido()
        {
           
            double cantidadApertura = 50;
            double saldoactual;

            gestionBancaria cuenta = new gestionBancaria(0);

            cuenta.aperturaCuenta(cantidadApertura);
            saldoactual = cuenta.obtenerSaldo();

            //Compruebo que el saldo inicial de la cuenta es la de apertura al estar entre "0" y "100".

            Assert.AreEqual(cantidadApertura,saldoactual,0.001,"La apertura no es correcta.");
        }

        [TestMethod]
        public void AperturaCuentaInvalido()
        {

            double cantidadApertura = 101;
            double saldoactual;
            double saldoError = 0;

            gestionBancaria cuenta = new gestionBancaria(0);

            cuenta.aperturaCuenta(cantidadApertura);
            saldoactual = cuenta.obtenerSaldo();
            
            //Por no entrar en Exepciones, simplemente compruebo que si esta fuera de rango, el saldo actual es "0", que eso significa que no se hizo la apertura.

            Assert.AreEqual(saldoError, saldoactual, 0.001, "La apertura no es correcta.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AperturaCuentaNull()
        {

            double cantidadApertura = double.Parse(null);
            double saldoactual;
            double saldoError = 0;

            gestionBancaria cuenta = new gestionBancaria(0);

            cuenta.aperturaCuenta(cantidadApertura);
            saldoactual = cuenta.obtenerSaldo();

            //Compruebo si se introduce valor Null, de error y ademas que no se haya modificado el saldo inicial.

            Assert.AreEqual(saldoError, saldoactual, 0.001, "La apertura no es correcta.");
        }
    }
}
