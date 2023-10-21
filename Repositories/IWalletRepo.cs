using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI.Repositories
{
    public interface IWalletRepo
    {
        void Update(Bank model);
        List<Bank> Get();
        Bank GetById(int id);
    }
}
