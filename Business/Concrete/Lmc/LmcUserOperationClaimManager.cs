using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LmcUserOperationClaimManager : ILmcUserOperationClaimService
    {
        ILmcUserOperationClaimDal _userOperationClaimDal;

        public LmcUserOperationClaimManager(ILmcUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }

        public async Task<IResult> Add(UserOperationClaim userOperationClaim)
        {
            await _userOperationClaimDal.Add(userOperationClaim);
            return new SuccessResult(Messages.UserOperationClaimAdded);
        }

        public async Task<IResult> Delete(UserOperationClaim userOperationClaim)
        {
            await _userOperationClaimDal.Delete(userOperationClaim);
            return new SuccessResult(Messages.UserOperationClaimDeleted);
        }

        public async Task<IDataResult<List<UserOperationClaim>>> GetAll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(await _userOperationClaimDal.GetAll());
        }

        public async Task<IDataResult<UserOperationClaim>> GetById(int userOperationClaimId)
        {
            return new SuccessDataResult<UserOperationClaim>(await _userOperationClaimDal.Get(u => u.UserOperationClaimId == userOperationClaimId));
        }

        public async Task<IDataResult<List<UserOperationClaim>>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<UserOperationClaim>>(await _userOperationClaimDal.GetAll(u => u.UserId == userId));
        }

        public async Task<IResult> Update(UserOperationClaim userOperationClaim)
        {
            await _userOperationClaimDal.Update(userOperationClaim);
            return new SuccessResult(Messages.UserOperationClaimUpdated);
        }

        
    }
}
