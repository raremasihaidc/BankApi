using AutoMapper;
using BankAPI.Data;
using BankAPI.Model;

namespace BankAPI.Repositories
{
    public class WalletRepo : IWalletRepo
    {
        private readonly IMapper _mapper;
        private readonly BankDbContext _dbContext;
        public WalletRepo(IMapper mapper, BankDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public void Update(Bank model)
        {
            _dbContext.Update(model);
            _dbContext.SaveChanges();
            
        }

        public List<Bank> Get()
        {
            return _dbContext.Banks.ToList();
        }

        public Bank GetById(int id)
        {
            var result = _dbContext.Banks.Find(id);
            return result;

        }
    }
}
