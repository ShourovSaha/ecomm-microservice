namespace Catalog.API.Settings
{
    public interface ICatalogDbSettings
    {
        public string ConnectionStr { get; set; }
        public string DbName { get; set; }
        public string CollectionName { get; set; }
    }
}
