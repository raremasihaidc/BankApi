using AutoMapper;
using BankAPI.DTOs;
using BankAPI.Handler;
using BankAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : Controller
    {
        private readonly IWalletHandler _walletHandler;
        readonly IMapper _mapper;
        public WalletController(IWalletHandler walletHandler, IMapper mapper)
        {
            _walletHandler = walletHandler;
            _mapper = mapper;
        }
        [HttpGet] public IActionResult Get() => Ok(_walletHandler.Get());

        [HttpPut]
        public IActionResult AddWallet(WalletDTO wallet)
        {
            try
            {   
                _walletHandler.Update(wallet);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("you already have the wallet");
            }
        }

    }
}
