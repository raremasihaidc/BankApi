using AutoMapper;
using BankAPI.Data;
using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI.Repositories
{
    public class AccountEntityRepo : IAccountEntityRepo
    {
        private readonly IMapper _mapper;
        private readonly BankDbContext _dbContext;
        public AccountEntityRepo(IMapper mapper, BankDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public List<Bank> Get()
        {
            return _dbContext.Banks.ToList();
            
        }

        public Bank GetById(int userid)
        {
            var result= _dbContext.Banks.Find(userid);
            return result;
        }
    }
}
