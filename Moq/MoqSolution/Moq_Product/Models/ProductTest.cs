using Lib.Interface;
using Lib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Lib;
using Moq;

namespace Moq_Product.Models
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void EvalueteCheckProductPrice()
        {
            Product cheapProduct = new Product()
            {
                Price = 35
            };

            Mock<ICheckProductPrice> mock = new Mock<ICheckProductPrice>();
            mock.Setup(m => m.CheckProductPrice(cheapProduct)).Returns("Cheap Product Price!");
            EvalueteCheckProductPrice verif = new EvalueteCheckProductPrice();
            // act
            var resultadoEsperado = mock.Object.CheckProductPrice(cheapProduct);
            var resultado = verif.CheckProductPrice(cheapProduct);
            // assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }
}
