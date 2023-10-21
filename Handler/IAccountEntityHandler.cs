using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI.Handler
{
    public interface IAccountEntityHandler
    {    
        List<AccountEntityDTO> Get();
        Bank GetById(int userid);

    }
}
