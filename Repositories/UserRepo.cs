using AutoMapper;
using BankAPI.Data;
using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI.Repositories
{
    public class UserRepo: IUserRepo
    {
        private readonly IMapper _mapper;
        private readonly BankDbContext _dbContext;
        public UserRepo(IMapper mapper, BankDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public void Add(Bank model)
        {
            _dbContext.Banks.Add(model);
            _dbContext.SaveChanges();
            
        }

        public void Delete(Bank model)
        {
            _dbContext.Banks.Remove(model);
            _dbContext.SaveChanges();
        }

        public List<Bank> Get()
        {
         return   _dbContext.Banks.ToList();

        }

        public Bank GetById(int id)
        {
            var result = _dbContext.Banks.Find(id);
            return result;
        }

        public void Update(Bank model)
        {
            _dbContext.Banks.Update(model);
            _dbContext.SaveChanges();
        }
    }
}
