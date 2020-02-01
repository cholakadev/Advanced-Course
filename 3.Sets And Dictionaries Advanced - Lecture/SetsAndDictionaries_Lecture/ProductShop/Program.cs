using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopInfo = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                var shop = input[0];
                if (shop.ToLower() == "revision")
                {
                    break;
                }

                var product = input[1];
                var price = double.Parse(input[2]);

                if (!shopInfo.ContainsKey(shop))
                {
                    shopInfo.Add(shop, new Dictionary<string, double>());
                    shopInfo[shop].Add(product, price);
                }
                else
                {
                    shopInfo[shop].Add(product, price);
                }
            }

            foreach (var shop in shopInfo)
            {
                Console.WriteLine(shop.Key +"->");
                foreach (var products in shop.Value)
                {
                    Console.WriteLine($"Product: {products.Key}, Price: {products.Value}");
                }
            }
        }
    }
}
