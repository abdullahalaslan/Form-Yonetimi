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
    public class FormRepository : IFormRepository
    {
        private readonly FormContext _context = new FormContext();

        public IEnumerable<Form> GetAll()
        {
            return _context.Form.Select(x => x);
        }

        public Form GetById(int id)
        {
            return _context.Form.FirstOrDefault(x => x.FormId==id);
        }

        public IQueryable<Form> GetMany(Expression<Func<Form, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Form obj)
        {
            _context.Form.Add(obj);

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
