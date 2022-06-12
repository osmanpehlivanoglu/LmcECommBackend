using Business.Abstract;
using Business.Constants;
using Core.Aspects.Caching;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LmcUserManager : ILmcUserService
    {
        ILmcUserDal _userDal;
        public LmcUserManager(ILmcUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task<IResult> Add(User user)
        {
            await _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }
        public async Task<IResult> Delete(User user)
        {
            await _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }
        
        public async Task<IDataResult<List<User>>> GetAll()
        {
            return new SuccessDataResult<List<User>>(await _userDal.GetAll());
        }

        public async Task<IDataResult<User>> GetById(int userId)
        {
            return new SuccessDataResult<User>(await _userDal.Get(u => u.UserId == userId));
        }
        public async Task<IResult> Update(User user)
        {
            await _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        //public List<OperationClaim> GetClaims(User user)
        //{
        //    return _userDal.GetClaims(user);
        //}

        //public User GetByMail(string email)
        //{
        //    return _userDal.Get(u => u.Email == email);
        //}

        public async Task<IDataResult<User>> GetByMail(string email)
        {
            return new SuccessDataResult<User>(await _userDal.Get(u => u.Email == email));
        }

        public async Task<IDataResult<List<OperationClaim>>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(await _userDal.GetClaims(user));
        }
    }
}
