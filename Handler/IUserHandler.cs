using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI.Handler
{
    public interface IUserHandler
    {
        void Add(Bank model);
        void Update(UserDTO model);
        void Delete(Bank model);
        List<UserDTO> Get();
        Bank GetById(int id);
    }
}
