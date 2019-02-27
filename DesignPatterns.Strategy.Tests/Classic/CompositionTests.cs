using DesignPatterns.Strategy.Classic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Strategy.Tests.Classic
{
    [TestClass]
    public class CompositionTests
    {
        [TestMethod]
        public void Repair_Simple_Success()
        {
            var quick = new Composition(new SimpleCompositor());
            quick.Repair();
        }

        [TestMethod]
        public void Repair_TeX_Success()
        {
            var slick = new Composition(new TeXCompositor());
            slick.Repair();
        }

        [TestMethod]
        public void Repair_Array_Success()
        {
            var iconic = new Composition(new ArrayCompositor(1000));
            iconic.Repair();
        }
    }
}
