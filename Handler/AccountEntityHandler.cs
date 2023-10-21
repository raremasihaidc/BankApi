using AutoMapper;
using BankAPI.DTOs;
using BankAPI.Model;
using BankAPI.Repositories;

namespace BankAPI.Handler
{
    public class AccountEntityHandler : IAccountEntityHandler
    {
        private readonly IAccountEntityRepo _repo;
        private readonly IMapper _mapper;
        public AccountEntityHandler(IAccountEntityRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public List<AccountEntityDTO> Get()
        {
            var result = _repo.Get();
            var getmodel = _mapper.Map<List<AccountEntityDTO>>(result);
            return getmodel;
        }

        public Bank GetById(int userid)
        {
           var m=_repo.GetById(userid);
            var g=_mapper.Map<AccountEntityDTO>(m);
            return m;
             
        }
    }
}
