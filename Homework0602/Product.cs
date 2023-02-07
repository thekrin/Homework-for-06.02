using System;
using System.Collections.Generic;
using System.Text;

namespace Homework0602
{
    internal class Product
    {
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }



        static int _totalCount;
        public Product()
        {
            _totalCount++;
            No = _totalCount;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"No: {No} - Name: {Name} - Price: {Price}");
        }

    }
}
