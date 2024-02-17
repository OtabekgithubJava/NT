using System.Runtime.InteropServices;
namespace Online.Course
{
    public interface ICustomerCRUD
    {
        public string Create(CustomersDTO customer);
        public IEnumerable<Customers> GetAll();
        public Customers GetByID(int id);
        public string DeleteByID(int id);
        public string Update(int id, CustomersDTO product);
    }
}