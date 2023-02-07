using System;
using System.Collections.Generic;
using System.Text;

namespace Homework0602
{
    internal class Store
    {       
            public Product[] products = new Product[0];
            private double DairyProductCountLimit;
            private double AlcoholPercentLimit;

            public void AddProduct(Product product)
            {
                if (DairyProductCountLimit <= 50 || AlcoholPercentLimit <= 10)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = product;
                }
            }

            public Product[] RemoveProduct(Product[] products, int No)
            {
                Console.WriteLine("No daxil edin");
                int no = Convert.ToInt32(Console.ReadLine());
                Product[] product3 = new Product[0];
                foreach (var item in products)
                {
                    if (item.No != no)
                    {
                        Array.Resize(ref product3, product3.Length + 1);
                        product3[products.Length - 1] = item;
                    }
                }
                return product3;
            }

            public bool HasProductByNo(int no)
            {
                foreach (var item in products)
                {
                    if (item.No == no)
                        return true;
                }
                return false;
            }

            public Product GetProductByNo(int no)
            {
                foreach (var item in products)
                {
                    if (item.No == no)
                    {
                        return item;
                    }
                }
                throw new Exception();
            }

            public Dairy[] GetDairyProducts(Dairy[] _product)
            {
                Dairy[] dairies = new Dairy[0];
                foreach (var item in products)
                {
                    if (item is Dairy)
                    {
                        Array.Resize(ref dairies, dairies.Length + 1);
                        dairies[dairies.Length - 1] = item as Dairy;
                    }
                }
                return dairies;
            }

            public Drink[] GetDrinkProducts(Drink[] _products)
            {
                Drink[] drinks = new Drink[0];
                foreach (var item in products)
                {
                    if (item is Drink)
                    {
                        Array.Resize(ref drinks, drinks.Length + 1);
                        drinks[drinks.Length - 1] = item as Drink;
                    }
                }
                return drinks;
            }
        
    }
}
