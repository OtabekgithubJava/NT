namespace Online.Course
{
    public class CustomerService : ICustomerService
    {
        public ICustomerCRUD _cs;

        public CustomerService(ICustomerCRUD cs)
        {
            _cs = cs;
        }
        public string Create(CustomersDTO customer)
        {
            if(customer.Full_Name == "" ||  customer.Full_Name == null)
            {
                return "Name isn't null";
            }
            if(customer.Age > 11)
            {
                try
                {
                    return _cs.Create(customer);
                }
                catch
                {
                    return "service error";
                }
            }
            else
            {
                return "You aren't old enough to be customer";
            }
        }

        public string DeleteByID(int id)
        {
            if(id < 0) 
            {
                return "Id should be greater than/equal to 0";
            }
            try
            {
                return _cs.DeleteByID(id);
            }
            catch
            {
                return "Service Error";
            }
        }

        public IEnumerable<Customers> GetAll()
        {
            try
            {
                return _cs.GetAll();
            }
            catch
            {
                return Enumerable.Empty<Customers>();
            }
        }

        public Customers GetByID(int id)
        {
            if (id < 0)
            {
                return new Customers();
            }
            try
            {
                return _cs.GetByID(id);
            }
            catch
            {
                return new Customers();
            }
        }

        public string Update(int id, CustomersDTO customer)
        {
            if (id < 0)
            {
                return "Id should be greater than/equal to 0";
            }
            if (customer.Full_Name == "" || customer.Full_Name == null)
            {
                return "Not null";
            }
            if(customer.Age > 11)
            {
                try
                {
                    return _cs.Update(id, customer);
                }
                catch
                {
                    return "Service Error";
                }
            }
            else
            {
                return "Inadequate age";
            }
        }
    }
}