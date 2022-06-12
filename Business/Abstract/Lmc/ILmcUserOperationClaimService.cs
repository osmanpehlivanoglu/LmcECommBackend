using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcUserOperationClaimService
    {
        Task<IDataResult<List<UserOperationClaim>>> GetAll();
        Task<IDataResult<UserOperationClaim>> GetById(int userOperationClaimId);
        Task<IDataResult<List<UserOperationClaim>>> GetByUserId(int userId);
        Task<IResult> Add(UserOperationClaim userOperationClaim);
        Task<IResult> Update(UserOperationClaim userOperationClaim);
        Task<IResult> Delete(UserOperationClaim userOperationClaim);
    }
}
