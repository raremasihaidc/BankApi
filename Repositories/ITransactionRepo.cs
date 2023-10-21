using BankAPI.Model;

namespace BankAPI.Repositories
{
    public interface ITransactionRepo
    {
        void Update(Bank model);
        List<Bank> Get();
        Bank GetById(int id);
    }
}
