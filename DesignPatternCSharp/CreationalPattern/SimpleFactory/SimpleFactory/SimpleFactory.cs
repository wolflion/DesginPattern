using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    #region test
    public interface IProduct { }
    public class ConcreteProductA : IProduct { }
    public class ConcreteProductB : IProduct { }
    public class Factory
    {
        public IProduct Create()
        {
            return new ConcreteProductA();
        }
    }
    #endregion

    public enum Category
    {
        A,
        B
    }
    public static class ProductFactory
    {
        public static IProduct Create(Category category)
        {
            switch (category)
            {
                case Category.A:
                    return new ConcreteProductA();
                case Category.B:
                    return new ConcreteProductB();
                default:
                    throw new NotSupportedException();
            }
        }
    }

    class SimpleFactory
    {
        static void Main(string[] args)
        {
            Factory factoryObj = new Factory();
            IProduct product = factoryObj.Create();
        }
    }
}
