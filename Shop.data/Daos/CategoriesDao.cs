

using Shop.data.Context;
using Shop.data.Entities;
using Shop.data.Interfaces;

namespace Shop.data.Daos
{
    public class CategoriesDao : ICategoriesRepository
    {
        private readonly ShopDbContext _context;

        public CategoriesDao(ShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categorie> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Categorie GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Add(Categorie entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Categorie entity)
        {
            _context.Categories.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Categories.Find(id);
            if (entity != null)
            {
                _context.Categories.Remove(entity);
                _context.SaveChanges();
            }
        }
    }

}
