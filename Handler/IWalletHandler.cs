using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI.Handler
{
    public interface IWalletHandler
    {
        void Update(WalletDTO model);
        List<WalletDTO> Get();
        Bank GetById(int id);
    }
}
