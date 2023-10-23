using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoneyExtension.Tests
{
    [TestClass]
    public class MoneyExtensionTests
    {
        private const int _valorExpected = 27998;

        [TestMethod]
        public void ShouldConvertDecimalToInt()
        {
            decimal valor = 279.98M;
            var cents = valor.ToCents();

            Assert.AreEqual(_valorExpected, cents);
            Assert.IsInstanceOfType(cents, typeof(int));
        }
    }
}