using BankAPI.Model;

namespace BankAPI.DTOs
{
    public class UserDTO 
    {
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public int UserPass { get; set; }
        public string UserName { get; set; }
    }
}
