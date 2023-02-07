using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace Homework0602
{
    internal class Dairy:Product
    {
        public double FatPercent { get; set; }

        public void ShowDairyProducts()
        {
            Console.WriteLine($"No: {No} - Name: {Name} - Price: {Price} - FatPercent: {FatPercent}");
        }
    }
}
