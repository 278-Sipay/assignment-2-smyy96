using SipayWebApi.Data.Domain;
using SipayWebApi.Data.Repository.Base;
using System.Linq.Expressions;

namespace SipayWebApi.Data.Repository;

public interface ITransactionRepository : IGenericRepository<Transaction>
{
    List<Transaction> GetByReference(string reference);
    
    List<Transaction> GetByParameters(TransactionFilter filter);
}
