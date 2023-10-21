using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI.Repositories
{
    public interface IAccountEntityRepo
    {
        List<Bank> Get();
        Bank GetById(int userid);
    }
}
