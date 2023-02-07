using System;

namespace Homework0602
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Drink drink = new Drink();

            Dairy dairy = new Dairy();

            Store store = new Store();

            Product product = new Product();
            Product[] product3 = new Product[0];
            string opr;
            do
            {
               
                Console.WriteLine("\n1: Drink product elave et");
                Console.WriteLine("2: Dairy product elave et");
                Console.WriteLine("3: Butun productlara bax");
                Console.WriteLine("4: Verilmis nomreli producta bax");
                Console.WriteLine("5: Drink productlara bax");
                Console.WriteLine("6: Dairy productlara bax");
                Console.WriteLine("7: Ada gore axtaris et");
                Console.WriteLine("8: Qiymet araligina gore axtaris et");
                Console.WriteLine("9: Siyahidan mehsulu sil");
                Console.WriteLine("0: Menyudan cix");
                Console.WriteLine("Zehmet olmasa emeliyyat secin.");
                opr = Console.ReadLine();

                switch (opr)
                {
                    case "1":
                        var dr = AddDrinkProduct();
                        store.AddProduct(dr);
                        break;
                    case "2":
                        var da = AddDairyProduct();
                        store.AddProduct(da);
                        break;
                    case "3":
                        foreach (Product item in store.products)
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "4":
                        Console.WriteLine("No: ");
                        string noString = Console.ReadLine();
                        int No = Convert.ToInt32(noString);
                        try
                        {
                            var wantProd = store.GetProductByNo(No);
                            wantProd.ShowInfo();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{No} nomreli mehsul yoxdur!" + ex.Message);
                        }
                        break;
                    case "5":
                        foreach (Drink item in store.products)
                        {
                            item.ShowDrinkProducts();
                        }

                        break;
                    case "6":
                        foreach (Dairy item in store.products)
                        {
                            item.ShowDairyProducts();
                        }
                        break;
                    case "7":
                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();
                        try
                        {
                            foreach (var item in store.products)
                            {
                                if (item.Name == name)
                                {
                                    item.ShowInfo();
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            throw new ProductNotFoundException("Product not found" + ex.Message);
                        }
                        break;
                    case "8":
                        Console.WriteLine("Minimum qiymeti daxil edin");
                        string minprice = Console.ReadLine();
                        double minPrice = Convert.ToDouble(minprice);

                        Console.WriteLine("Maksimum qiymeti daxil edin");
                        string maxprice = Console.ReadLine();
                        double maxPrice = Convert.ToDouble(maxprice);
                        try
                        {
                            foreach (var item in store.products)
                            {
                                if (item.Price < maxPrice && item.Price > minPrice)
                                {
                                    item.ShowInfo();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new ProductNotFoundException("Product not found" + ex.Message);
                        }

                        break;
                    case "9":
                        Console.WriteLine("No daxil edin");
                        int no = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            foreach (var item in store.products)
                            {
                                if (item.No != no)
                                {
                                    Array.Resize(ref product3, product3.Length + 1);
                                    product3[store.products.Length - 1] = item;
                                }
                            }
                        }
                        catch
                        {
                            throw new Exception();
                        }

                        break;
                    case "0":
                        Console.WriteLine("Thanks");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim etdiniz");
                        break;
                }
            } while (opr != "0");
        }

        static Product AddDrinkProduct()
        {
            Console.WriteLine("Mehsul nomresi elave edin");
            string Num = Console.ReadLine();
            int num = Convert.ToInt32(Num);

            Console.Write("\nName: ");
            string Name1 = Console.ReadLine();

            string alcoholpercent;
            double AlcoholPercent;
            do
            {
                Console.Write("\nAlcoholPercent: ");
                alcoholpercent = Console.ReadLine();
            } while (!double.TryParse(alcoholpercent, out AlcoholPercent));

            string priceStr;
            double Price;
            do
            {
                Console.Write("\nPrice: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out Price));


            Drink drink1 = new Drink
            {
                No = num,
                Name = Name1,
                Price = Price,
                AlcoholPercent = AlcoholPercent
            };

            return drink1;
        }

        static Product AddDairyProduct()
        {
            Console.WriteLine("Mehsul nomresi elave edin");
            string Num = Console.ReadLine();
            int num = Convert.ToInt32(Num);

            Console.Write("\nName: ");
            string Name1 = Console.ReadLine();

            string fatpercent;
            double FatPercent;
            do
            {
                Console.Write("\nFatPercent: ");
                fatpercent = Console.ReadLine();
            } while (!double.TryParse(fatpercent, out FatPercent));

            string priceStr;
            double Price;
            do
            {
                Console.Write("\nPrice: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out Price));


            Dairy dairy1 = new Dairy
            {
                No = num,
                Name = Name1,
                Price = Price,
                FatPercent = FatPercent
            };

            return dairy1;
        }

    }
    
}