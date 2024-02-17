namespace Online.Course
{
    public class CategoryService : ICategoryService
    {
        public ICategoryCRUD _cr;
        public CategoryService(ICategoryCRUD cr)
        {
            _cr = cr;
        }

        public string Create(CategoryDTO category)
        {
            if (category.Category_name == null || category.Category_name == "")
            {
                return "null";
            }
            try
            {
                return _cr.Create(category);
            }
            catch
            {
                return "Error";
            }

        }

        public string DeleteByID(int id)
        {
            if(id < 0)
            {
                return "Consider Id >= 0";
            }
            try
            {
                return _cr.DeleteByID(id);
            }
            catch
            {
                return "Error";
            }
        }

        public IEnumerable<Category> GetAll()
        {
            try
            {
                return _cr.GetAll();
            }
            catch
            {
                return Enumerable.Empty<Category>();
            }
        }

        public Category GetByID(int id)
        {
            if (id < 0)
            {
                return new Category();
            }
            try
            {
                return _cr.GetByID(id);
            }
            catch
            {
                return new Category();
            }
        }

        public string Update(int id, CategoryDTO category)
        {
            if (id < 0)
            {
                return "Consider Id >= 0";
            }
            if (category.Category_name == null || category.Category_name == "")
            {
                return "null";
            }
            try
            {
                return _cr.Update(id, category);
            }
            catch
            {
                return "Error";
            }
        }
    }
}