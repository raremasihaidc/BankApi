using BankAPI.Model;

namespace BankAPI.DTOs
{
    public class LoanDTO
    {
        public int WalletId { get; set; }
        public int UserEntity { get; set; }
        public int LoanId { get; set; }
        public int RequestDate { get; set; }
        public int RequestAmount { get; set; }
    }
}
