using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepostory<T>
    {
        //Using Generics <T> is a generic name of anything;
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // = for writing filters 
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);        
        

    }
}
