using AutoMapper;
using BankAPI.DTOs;
using BankAPI.Model;

namespace BankAPI
{
    public class AutoMapperProfile :Profile
    { public AutoMapperProfile()
        {
            CreateMap<Bank, LoanDTO>();
            CreateMap<Bank,UserDTO>();
            CreateMap<Bank,WalletDTO>();
            CreateMap<Bank , TransactionDTO>();
            CreateMap<LoanDTO, Bank>();
            CreateMap<UserDTO,Bank>();
            CreateMap<WalletDTO,Bank>();
            CreateMap<TransactionDTO ,Bank>();
        }
    }
}
