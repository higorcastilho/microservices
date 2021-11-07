using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(productCollection => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }

            static IEnumerable<Product> GetMyProducts() 
            {
                return new List<Product>()
                {
                    new Product()
                    {
                        Id = "5099803df3f4948bd2f98391",
                        Name = "IPhone X",
                        Description = "Beautiful IPhone",
                        Image = "product-1.png",
                        Price = 950.00M,
                        Category = "Smart Phone"
                    },
                    new Product()
                    {
                        Id = "5099802df3f4948bd2f98391",
                        Name = "Samgung 10",
                        Description = "Beautiful Samsung",
                        Image = "product-2.png",
                        Price = 250.00M,
                        Category = "Smart Phone"
                    },
                    new Product()
                    {
                        Id = "5029802df3f4948bd2f98391",
                        Name = "TV Samsung",
                        Description = "Beautiful TV Samsung",
                        Image = "product-3.png",
                        Price = 1250.00M,
                        Category = "Smart TV"
                    },
                    new Product()
                    {
                        Id = "7099802df3f4948bd2f98391",
                        Name = "Washing Machine",
                        Description = "Beautiful washing machine",
                        Image = "product-4.png",
                        Price = 1250.00M,
                        Category = "Home Appliances"
                    }
                };
            }
        }
    }
}
