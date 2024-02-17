namespace Online.Course
{
    public class ShopService : IShopService
    {
        public IShopCRUD _shp;
        public ShopService(IShopCRUD shopCRUD)
        {
            _shp = shopCRUD;
        }
        public string Create(ShopsDTO shop)
        {
            if (shop.Shop_Name == null || shop.Shop_Name == "")
            {
                return "null";
            }
            try
            {
                return _shp.Create(shop);
            }
            catch
            {
                return "Service Error";
            }
        }

        public string DeleteByID(int id)
        {
            if (id < 0)
            {
                return "Follow: Id >= 0";
            }
            try
            {
                return _shp.DeleteByID(id);
            }
            catch
            {
                return "Service Error";
            }
        }

        public IEnumerable<Shops> GetAll()
        {
            try
            {
                return _shp.GetAll();
            }
            catch
            {
                return Enumerable.Empty<Shops>();
            }
        }

        public Shops GetByID(int id)
        {
            if (id < 0)
            {
                return new Shops();
            }
            try
            {
                return _shp.GetByID(id);
            }
            catch
            {
                return new Shops();
            }
        }

        public string Update(int id, ShopsDTO shop)
        {
            if (id < 0)
            {
                return "Id must be greater than/equal to 0";
            }
            if (shop.Shop_Name == null || shop.Shop_Name == "")
            {
                return "nu;; error";
            }
            try
            {
                return _shp.Update(id, shop);
            }
            catch
            {
                return "Services Error";
            }
        }
    }
}