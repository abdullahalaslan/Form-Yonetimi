using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormYonetimi.Core.Infrastructure
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        IQueryable<T> GetMany(Expression<Func<T, bool>> expression);

        void Insert(T obj);

        void Save();
    }
}
