using Microsoft.EntityFrameworkCore;
using SipayWebApi.Base;
using SipayWebApi.Data.Domain;
using SipayWebApi.Data.Repository.Base;
using System.Linq.Expressions;

namespace SipayWebApi.Data.Repository
{

    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : BaseModel
    {
        private readonly SimDbContext dbContext;
        public GenericRepository(SimDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Entity> Where(Expression<Func<Entity, bool>> filterExpression)
        {
            return dbContext.Set<Entity>().Where(filterExpression).ToList();
            //return dbContext.Set<Entity>().Where(expression).AsQueryable();
        }
    }
}
