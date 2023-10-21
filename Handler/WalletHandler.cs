using AutoMapper;
using BankAPI.Data;
using BankAPI.DTOs;
using BankAPI.Model;
using BankAPI.Repositories;

namespace BankAPI.Handler
{
    public class WalletHandler : IWalletHandler
    {
        private readonly BankDbContext _db;
        private readonly IUserRepo _repo;
        private readonly IMapper _mapper;
        public WalletHandler(IUserRepo repo, IMapper mapper, BankDbContext db)
        {
            _db = db;
            _repo = repo;
            _mapper = mapper;
        }
        public void Update(WalletDTO model)
        {
            var user = _db.Banks.Find(model.UserId);
            if (user.UserPass == model.UserPass && user.UserName == model.UserName)
            {
                if (user.WalletId == 0)
                {
                    user.WalletId += model.UserPass;
                    user.UserEntity += 30000;
                }
                else
                {
                    user.UserEntity += model.UserEntity;
                }
            }
            _repo.Update(user);
        }

        public Bank GetById(int id)
        {
            var model = _repo.GetById(id);
            return model;

        }

        List<WalletDTO> IWalletHandler.Get()
        {
            var result = _repo.Get();
            var getmodel = _mapper.Map<List<WalletDTO>>(result);
            return getmodel;
        }
    }
}
