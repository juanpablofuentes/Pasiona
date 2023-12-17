using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumerosComplejos;

namespace NumerosComplejosPruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            NumeroComplejo a = new NumeroComplejo(1, 1);
            NumeroComplejo b = new NumeroComplejo(1, 1);
            NumeroComplejo c = new NumeroComplejo(2, 2);


            // Act
            NumerosComplejosPruebas suma = a + b;

            // Assert
            Assert.AreEqual(c, suma);
        }
    }
}
