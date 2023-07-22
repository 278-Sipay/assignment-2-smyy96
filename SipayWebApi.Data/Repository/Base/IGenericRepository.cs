using System.Linq.Expressions;

namespace SipayWebApi.Data.Repository.Base
{

    public interface IGenericRepository<Entity> where Entity : class
    {
        IEnumerable<Entity> Where(Expression<Func<Entity, bool>> filterExpression);
    }
}