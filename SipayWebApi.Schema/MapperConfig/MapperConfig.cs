using AutoMapper;
using SipayWebApi.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipayWebApi.Schema;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<CustomerRequest, Customer>();
        CreateMap<Customer, CustomerResponse>();

        CreateMap<AccountRequest, Account>();
        CreateMap<Account, AccountResponse>();

        CreateMap<TransactionRequest, Transaction>();
        CreateMap<Transaction, TransactionResponse>();
    }
}
