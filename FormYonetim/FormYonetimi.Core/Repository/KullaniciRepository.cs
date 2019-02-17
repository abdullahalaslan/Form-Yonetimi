using FormYonetimi.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormYonetimi.Data.Model;
using FormYonetimi.Data.DataContext;
using System.Linq.Expressions;

namespace FormYonetimi.Core.Repository
{
    public class KullaniciRepository : IKullaniciRepository
    {
        private readonly FormContext _context = new FormContext();

        public IEnumerable<Kullanici> GetAll()
        {
            return _context.Kullanici.Select(x => x);
        }

        public Kullanici GetById(int id)
        {
            return _context.Kullanici.FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Kullanici> GetMany(Expression<Func<Kullanici, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Kullanici obj)
        {
            _context.Kullanici.Add(obj);

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
