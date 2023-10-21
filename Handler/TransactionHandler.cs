using AutoMapper;
using BankAPI.Data;
using BankAPI.DTOs;
using BankAPI.Model;
using BankAPI.Repositories;

namespace BankAPI.Handler
{
    public class TransactionHandler : ITransactionHandler
    {
        private readonly BankDbContext _db;
        private readonly ITransactionRepo _repo;
        private readonly IMapper _mapper;
        public TransactionHandler(ITransactionRepo repo, IMapper mapper, BankDbContext db)
        {
            _db = db;
            _repo = repo;
            _mapper = mapper;
        }
        public List<TransactionDTO> Get()
        {

            var model = _repo.Get();
            var getresult = _mapper.Map<List<TransactionDTO>>(model);
            return getresult;
        }

        public Bank GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Update(TransactionDTO model)
        {
            int failed = 0;
            var destination = _db.Banks.FirstOrDefault(x => x.WalletId == model.DestinationWalletId);
            var source = _db.Banks.FirstOrDefault(x => x.WalletId == model.SourceWalletId);
            if (failed < 4)
            {
                if ((destination != null && source != null) && (source != destination))
                {
                    if (source.UserEntity > model.RequestAmount)
                    {
                        destination.UserEntity += model.RequestAmount;
                        source.UserEntity -= model.RequestAmount;
                        _repo.Update(source);
                        _repo.Update(destination);
                    }
                    else
                    {   
                        failed++;
                        
                    }
                }
            }
            else
            {
                model.IsUserAcountBloked = true;
                var f = _repo.GetById(model.SourceWalletId);
                if (model.IsUserAcountBloked)
                {
                    if (f.UserEntity < f.UserEntity + 100000)
                    {
                        throw new Exception("You are locked! , Your account will be unlocked by increasing your enitity up to 100000 ");
                    }
                    else
                    {
                        //    f.UserEntity += 100000;
                        //    _repo.Update(f);
                        failed = 0;
                    }
                }
            }
        }
    }

}


