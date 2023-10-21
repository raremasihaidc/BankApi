using AutoMapper;
using BankAPI.DTOs;
using BankAPI.Handler;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : Controller
    {
        private readonly ITransactionHandler _transactionHandler;
        readonly IMapper _mapper;
        public TransactionController(ITransactionHandler transactionHandler, IMapper mapper)
        {
            _transactionHandler = transactionHandler;
            _mapper = mapper;
        }

        [HttpPut]
        public IActionResult AddWallet(TransactionDTO transaction)
        {
            //try
           // {
                _transactionHandler.Update(transaction);
                return Ok();
         //   }
          //  catch (Exception ex)
            //
             //   return BadRequest("failed");
           // }
        }
    }
}
