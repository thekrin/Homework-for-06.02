using System;
using System.Collections.Generic;
using System.Text;

namespace Homework0602
{
    internal class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string message) : base(message)
        {
            Console.WriteLine("Product not Found" + message);
        }
    }
}
