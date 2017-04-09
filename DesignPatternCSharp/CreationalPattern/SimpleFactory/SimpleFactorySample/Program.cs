using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            IChart chart;
            chart = ChartFactory.GetChart("histo");
            chart.Display();
            Console.Read();
        }
    }
}
