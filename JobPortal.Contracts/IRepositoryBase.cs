using System.Linq.Expressions;

namespace JobPortal.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Create(List<T> entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
