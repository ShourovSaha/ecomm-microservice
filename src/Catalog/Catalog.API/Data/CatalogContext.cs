using Catalog.API.Data.Interfaces;
using Catalog.API.Entities;
using Catalog.API.Settings;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext: ICatalogContext
    {
        public IMongoCollection<Product> Products { get;}

        public CatalogContext(ICatalogDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionStr);
            var db = client.GetDatabase(settings.DbName);
            Products = db.GetCollection<Product>(settings.CollectionName);
            CatalogContextSeed.SeedData(Products);
        }
    }
}
