using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SimpleFactorySample
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void test()
        {
            IChart chart;
            chart = ChartFactory.GetChart("histo");
            Assert.AreEqual(chart.GetType(), typeof(HistogramChart));
        }
    }
}
