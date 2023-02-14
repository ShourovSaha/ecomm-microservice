using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existsProduct = productCollection.Find(p => true).Any();
            if (!existsProduct)
            {
                productCollection.InsertMany(getPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> getPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Name = "Realme 5 Pro",
                    Catagory = "Android Phone",
                    Summary = "Smart phone, made in India.",
                    Price = 17200,
                    Description = "Processore: SD 712. RAM: 4 GB. ROM: 64 GB.",
                    ImageFile = "ImageFile"
                },
                new Product
                {
                    Name = "HP Pavilion",
                    Catagory = "Laptop",
                    Summary = "Smart laptop, made in India.",
                    Price = 57500,
                    Description = "Processore: AMD Ryzen 7 5700U. RAM: 8 GB. SSD: 500 GB.",
                    ImageFile = "ImageFile"
                }
            };
        }
    }
}
