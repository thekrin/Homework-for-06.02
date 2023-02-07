using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace Homework0602
{
    internal class Drink:Product
    {
        public double AlcoholPercent { get; set; }

        public void ShowDrinkProducts()
        {
            Console.WriteLine($"No: {No}Name: {Name} - Price: {Price} - AlcoholPercent: {AlcoholPercent}");
        }
    }
}
