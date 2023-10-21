using AutoMapper;
using BankAPI.Handler;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountEntityController : Controller
    {
       
        readonly IMapper _mapper;
        public AccountEntityController( IMapper mapper)
        {
    
            _mapper = mapper;
        }

    }
}
