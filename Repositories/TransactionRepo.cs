using AutoMapper;
using BankAPI.Data;
using BankAPI.Model;

namespace BankAPI.Repositories
{
    public class TransactionRepo : ITransactionRepo
    {
        private readonly IMapper _mapper;
        private readonly BankDbContext _dbContext;
        public TransactionRepo(IMapper mapper, BankDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public List<Bank> Get()
        {
            return _dbContext.Banks.ToList();
        }

        public Bank GetById(int id)
        {
            var r = _dbContext.Banks.Find(id);
            return r;
        }

        public void Update(Bank model)
        {
            _dbContext.Banks.Update(model);
            _dbContext.SaveChanges();
        }
    }
}
