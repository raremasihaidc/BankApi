using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI.Handler
{
    public interface ITransactionHandler
    {
        void Update(TransactionDTO model);
        List<TransactionDTO> Get();
        Bank GetById(int id);

    }
}
