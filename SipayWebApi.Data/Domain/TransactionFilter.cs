using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipayWebApi.Data.Domain
{
    public class TransactionFilter
    {
        public int? AccountNumber { get; set; }
        public string? ReferenceNumber { get; set; }
        public decimal? MinAmountCredit { get; set; }
        public decimal? MaxAmountCredit { get; set; }
        public decimal? MinAmountDebit { get; set; }
        public decimal? MaxAmountDebit { get; set; }
        public string? Description { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}