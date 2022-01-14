using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Using Generics <T> is a generic name of anything;
    //Generic Constraint
    //class referance type
    //IEntitiy: It must Be Ientitiy or implemented IEntitiy
    //new: it must be newed


    public interface IEntityRepostory<T> where T:class,IEntity, new()
    {        
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // = for writing filters 
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);        
        

    }
}
