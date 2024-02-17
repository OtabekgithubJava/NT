using System.Globalization;

namespace Online.Course
{
    public interface IProductCRUD
    {
        public string Create(ProductDTO product);
        public IEnumerable<Product> GetAll();

        public Product GetByID(int id);
        public string DeleteByID(int id);
        public string Update(int id,ProductDTO product);

    }
}