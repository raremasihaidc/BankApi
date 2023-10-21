using BankAPI.Model;
using System.Text.Json.Serialization;

namespace BankAPI.DTOs
{
    public class WalletDTO
    {
        public int UserPass { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public int WalletId { get; set; }
        public int UserEntity { get; set; }
        public Boolean IsUserAcountBloked { get; set; }
    }
}
