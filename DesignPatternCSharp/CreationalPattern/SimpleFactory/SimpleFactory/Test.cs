using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SimpleFactory
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void test()
        {
            Factory factoryObj = new Factory();
            IProduct product = factoryObj.Create();
            Assert.AreEqual(product.GetType(), typeof(ConcreteProductA));
        }
        [Test]
        public void test1()
        {
            IProduct product = ProductFactory.Create(Category.B);
            Assert.IsNotNull(product);
            Assert.AreEqual(typeof(ConcreteProductB), product.GetType());
        }
    }
}
