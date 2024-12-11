

using Shop.data.Context;
using Shop.data.Entities;
using Shop.data.Interfaces;

namespace Shop.data.Daos
{
    public class EmployeesDao : IEmployeesRepository
    {
        private readonly ShopDbContext _context;

        public EmployeesDao(ShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Add(Employee entity)
        {
            _context.Employees.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Employee entity)
        {
            _context.Employees.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Employees.Find(id);
            if (entity != null)
            {
                _context.Employees.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
