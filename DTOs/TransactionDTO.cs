using System.Text.Json.Serialization;

namespace BankAPI.DTOs
{
    public class TransactionDTO
    {
      [JsonIgnore] public int UserEntity { get; set; }
      [JsonIgnore]  public int WalletId { get; set; }
        public int SourceWalletId { get; set; }
        public int  DestinationWalletId { get; set; }
        public int RequestAmount { get; set; }
        public int UserPass { get; set; }
        public string UserName { get; set; }
        public Boolean IsUserAcountBloked { get; set; }
       
    }
}
