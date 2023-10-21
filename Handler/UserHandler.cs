using AutoMapper;
using BankAPI.Data;
using BankAPI.DTOs;
using BankAPI.Model;
using BankAPI.Repositories;

namespace BankAPI.Handler
{
    public class UserHandler : IUserHandler
    {
        
        private readonly IUserRepo _repo;
        private readonly IMapper _mapper;
        public UserHandler(IUserRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Add(Bank model)
        {
        _repo.Add(model);
           
        }

        public void Delete(Bank model)
        {
            var r = _repo.GetById(model.UserId);
            if(r != null)
            {
                _repo.Delete(r);
            } 
        }

        public List<UserDTO> Get()
        {
            var result = _repo.Get();
            var getmodel=_mapper.Map<List<UserDTO>>(result);
            return getmodel;
            
        }

        public Bank GetById(int id)
        {
            var getmodel=_repo.GetById(id);
            return getmodel;
        }


        public void Update(UserDTO model)
        {
            var updatemodel = _repo.GetById(model.UserId);
            if(updatemodel != null)
            {
                updatemodel.UserFullName = model.UserFullName;
                updatemodel.UserName = model.UserName;
                updatemodel.UserPass = model.UserPass;
            }
            _repo.Update(updatemodel);
           
        }
    }
}
