using FormYonetimi.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormYonetimi.Data.Model;
using System.Linq.Expressions;
using FormYonetimi.Data.DataContext;

namespace FormYonetimi.Core.Repository
{
   public class AdminRepository : IAdminRepository
    {
        private readonly FormContext _context = new FormContext();

        public IEnumerable<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Admin GetById(int id)
        {
            return _context.Admin.FirstOrDefault(x => x.AdminId == id);
        }

        public IQueryable<Admin> GetMany(Expression<Func<Admin, bool>> expression)
        {
            return _context.Admin.Where(expression);
        }

        public void Insert(Admin obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
