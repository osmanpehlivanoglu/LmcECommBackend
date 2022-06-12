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
    public class LmcOperationClaimManager : ILmcOperationClaimService
    {
        ILmcOperationClaimDal _operationClaimDal;

        public LmcOperationClaimManager(ILmcOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }

        public async Task<IResult> Add(OperationClaim operationClaim)
        {
            await _operationClaimDal.Add(operationClaim);
            return new SuccessResult(Messages.OperationClaimAdded);
        }

        public async Task<IResult> Delete(OperationClaim operationClaim)
        {
            await _operationClaimDal.Delete(operationClaim);
            return new SuccessResult(Messages.OperationClaimDeleted);
        }

        public async Task<IDataResult<List<OperationClaim>>> GetAll()
        {
            return new SuccessDataResult<List<OperationClaim>>(await _operationClaimDal.GetAll());
        }

        public async Task<IDataResult<OperationClaim>> GetById(int operationClaimId)
        {
            return new SuccessDataResult<OperationClaim>(await _operationClaimDal.Get(m => m.OperationClaimId == operationClaimId));
        }

        public async Task<IResult> Update(OperationClaim operationClaim)
        {
            await _operationClaimDal.Update(operationClaim);
            return new SuccessResult(Messages.OperationClaimUpdated);
        }
    }
}
