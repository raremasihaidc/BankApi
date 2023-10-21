using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI.Repositories
{
    public interface IUserRepo
    {
         void Add(Bank model);
        void Update(Bank model);
        void Delete(Bank model);
        List<Bank> Get();
        Bank GetById(int id);
    }
}
