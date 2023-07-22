using Microsoft.EntityFrameworkCore;
using SipayWebApi.Data.Domain;
using SipayWebApi.Data.Repository.Base;
using SipayWebApi.Data;
using System.Linq.Expressions;

namespace SipayWebApi.Data.Repository
{

    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly SimDbContext dbContext;
        public TransactionRepository(SimDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Transaction> GetByReference(string reference)
        {
            return dbContext.Set<Transaction>().Where(x => x.ReferenceNumber == reference).ToList();
        }


        public List<Transaction> GetByParameters(TransactionFilter filter)
        {
            var transactions = dbContext.Transaction.ToList();

           
            
            if (filter.AccountNumber.HasValue) // AccountNumber eşit olanları getiriyor
                transactions = transactions.Where(t => t.AccountNumber == filter.AccountNumber.Value).ToList();
            

            if (!string.IsNullOrEmpty(filter.ReferenceNumber))// ReferenceNumber eşit olanları getiriyor
                transactions = transactions.Where(t => t.ReferenceNumber == filter.ReferenceNumber).ToList();

                       
            if (filter.MinAmountCredit.HasValue && filter.MaxAmountCredit.HasValue)//Verilen iki değer arasındaki(max min) CreditAmount değerlerini veriyor.
                transactions = transactions.Where(t => t.CreditAmount >= filter.MinAmountCredit.Value && t.CreditAmount <= filter.MaxAmountCredit.Value).ToList();

            if (filter.BeginDate.HasValue && filter.EndDate.HasValue)//Verilen iki tarih arasında olan değerleri getiriyor.
                transactions = transactions.Where(t => t.TransactionDate >= filter.BeginDate.Value && t.TransactionDate <= filter.EndDate.Value).ToList();





            // Diğer Filtreleme seçenekleri (ödevde yoktu fazladan ekledim, eşit olanları ya da o değerden büyük ve küçük olan verileri getiriyor.)

            if (filter.MinAmountCredit.HasValue)
                transactions = transactions.Where(t => t.CreditAmount >= filter.MinAmountCredit.Value).ToList();

            if (filter.MaxAmountCredit.HasValue)
                transactions = transactions.Where(t => t.CreditAmount <= filter.MaxAmountCredit.Value).ToList();

            if (filter.MinAmountDebit.HasValue)
                transactions = transactions.Where(t => t.DebitAmount >= filter.MinAmountDebit.Value).ToList();

            if (filter.MaxAmountDebit.HasValue)
                transactions = transactions.Where(t => t.DebitAmount <= filter.MaxAmountDebit.Value).ToList();

            if (!string.IsNullOrEmpty(filter.Description))
                transactions = transactions.Where(t => t.Description == filter.Description).ToList();

            if (filter.BeginDate.HasValue)
                transactions = transactions.Where(t => t.TransactionDate >= filter.BeginDate.Value).ToList();

            if (filter.EndDate.HasValue)
                transactions = transactions.Where(t => t.TransactionDate <= filter.EndDate.Value).ToList();



            return transactions;
        }
    }
}

