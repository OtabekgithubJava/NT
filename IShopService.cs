namespace Online.Course
{
    public interface IShopService
    {
        public string Create(ShopsDTO shop);
        public IEnumerable<Shops> GetAll();
        public Shops GetByID(int id);
        public string DeleteByID(int id);
        public string Update(int id, ShopsDTO shop);
    }
}