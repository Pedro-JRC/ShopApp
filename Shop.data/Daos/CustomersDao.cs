

using Shop.data.Context;
using Shop.data.Entities;
using Shop.data.Interfaces;

namespace Shop.data.Daos
{
    public class CustomersDao : ICustomersRepository
    {
        private readonly ShopDbContext _context;

        public CustomersDao(ShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Customer entity)
        {
            _context.Customers.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Customers.Find(id);
            if (entity != null)
            {
                _context.Customers.Remove(entity);
                _context.SaveChanges();
            }
        }
    }

}
