using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcOperationClaimService
    {
        Task<IDataResult<List<OperationClaim>>> GetAll();
        Task<IDataResult<OperationClaim>> GetById(int operationClaimId);
        Task<IResult> Add(OperationClaim operationClaim);
        Task<IResult> Update(OperationClaim operationClaim);
        Task<IResult> Delete(OperationClaim operationClaim);
    }
}
