namespace Online.Course
{
    public class ProductService : IProductService
    {
        private readonly IProductCRUD _productRepo;
        public ProductService(IProductCRUD repo)
        {
            _productRepo = repo;
        }
        public string Create(ProductDTO product)
        {
            if (product.Product_name == null || product.Product_name == "")
            {
                return "null error";
            }
            return _productRepo.Create(product);
        }

        public string DeleteByID(int id)
        {
            if (id < 0)
            {
                return "Id must be greater than/equal to 0";
            }
            try
            {
                return _productRepo.DeleteByID(id);
            }
            catch
            {
                return "Error";
            }
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                return _productRepo.GetAll();
            }
            catch
            {
                return Enumerable.Empty<Product>();
            }
        }

        public Product GetByID(int id)
        {
            if (id < 0)
            {
                return new Product();
            }
            try
            {
                return _productRepo.GetByID(id);
            }
            catch
            {
                return new Product();
            }
        }

        public string Update(int id, ProductDTO product)
        {

            if (product.Product_name == null || product.Product_name == "")
            {
                return "null error";
            }
            if (id < 0)
            {
                return "iId >= 0";
            }
            try
            {
                return _productRepo.Update(id, product);
            }
            catch
            {
                return "Service Error";
            }

        }
    }
}