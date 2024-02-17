namespace Online.Course
{
    public interface IShopCRUD
    {
        public string Create(ShopsDTO shop);
        public IEnumerable<Shops> GetAll();
        public Shops GetByID(int id);
        public string DeleteByID(int id);
        public string Update(int id, ShopsDTO product);
    }
}