<<<<<<< HEAD
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;
using System;

namespace gestionBancariaTest
{
    [TestClass]
    public class GestionBancariaTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso()
        {
            //preparación del caso de prueba
            double saldoinicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoinicial);

            //Método a probar
            cuenta.realizarIngreso(ingreso);
            //afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoReintrego()
        {
            //preparamos los casos de prueba
            double saldo = 1000;
            double retiro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldo);

            //metodo a probar
            cuenta.realizarReintegro(retiro);

            //valor esperado vs valor obtenido
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
            //duda que tengo, viendo el resultado de la prueba, no me indica exactamente cual es el problema, en gestionbancaria.cs he cambiado el > y < por >= y <=, preguntar.
            //Que quierre decir sus clases de equivalencia, fronteras y preparar los diferentes casos de prueba
            //Tendremos ejercicios solucionados
            //explicar las excepciones
        }
    }
}
=======
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;
using System;

namespace gestionBancariaTest
{
    [TestClass]
    public class GestionBancariaTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoIngreso()
        {
            //preparación del caso de prueba
            double saldoinicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoinicial);

            //Método a probar
            cuenta.realizarIngreso(ingreso);
            //afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void validarMetodoReintrego()
        {
            //preparamos los casos de prueba
            double saldo = 1000;
            double retiro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldo);

            //metodo a probar
            cuenta.realizarReintegro(retiro);

            //valor esperado vs valor obtenido
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
            //duda que tengo, viendo el resultado de la prueba, no me indica exactamente cual es el problema, en gestionbancaria.cs he cambiado el > y < por >= y <=, preguntar.
            //Que quierre decir sus clases de equivalencia, fronteras y preparar los diferentes casos de prueba
            //Tendremos ejercicios solucionados
            //explicar las excepciones
        }
    }
}
>>>>>>> Realización de excepciones
