using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BankAPI.Model
{
    public class Bank 
    {
       
      [Key] public int UserId { get; set; }
        public string UserFullName { get; set; }
        public int UserPass { get; set; }
        public string UserName { get; set; }
        public int WalletId { get; set; }
        public int UserEntity { get; set; }
        public Boolean IsUserAcountBloked { get; set; }
        public int LoanId { get; set; }
        public int RequestDate { get; set; }
        public int RequestAmount { get; set; }
        public int SourceWalletId { get; set; }
        public int DestinationWalletId { get; set; }
    }
}
