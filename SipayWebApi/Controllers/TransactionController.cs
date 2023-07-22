using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SipayWebApi.Data.Repository;
using SipayWebApi.Base;
using SipayWebApi.Data.Domain;
using SipayWebApi.Schema;

namespace SipayWebApi.Service
{
    [ApiController]
    [Route("sipay/api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionRepository _repository;
        private readonly IMapper _mapper;

        public TransactionController(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet("GetByReference")]
        public ApiResponse<List<TransactionResponse>> GetByReference([FromQuery] string ReferenceNumber)
        {
            var entityList = _repository.Where(x => x.ReferenceNumber == ReferenceNumber).ToList();
            var mapped = _mapper.Map<List<Transaction>, List<TransactionResponse>>(entityList);
            return new ApiResponse<List<TransactionResponse>>(mapped);
        }



        [HttpGet("GetByParameters")]
        public List<TransactionResponse> GetByParameters([FromQuery] TransactionFilter filter)
        {
            var transactions = _repository.GetByParameters(filter);
            var mapped = _mapper.Map<List<Transaction>, List<TransactionResponse>>(transactions);
            return new List<TransactionResponse>(mapped);
        }

    }
}
