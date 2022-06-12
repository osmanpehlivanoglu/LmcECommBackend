using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Lmc
{
    public class EfLmcUserDal : EfEntityRepositoryBase<User, LmcContext>, ILmcUserDal
    {
        public async Task<List<OperationClaim>> GetClaims(User user)
        {
            using (var context = new LmcContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.OperationClaimId equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { OperationClaimId = operationClaim.OperationClaimId, Name = operationClaim.Name };
                return await result.ToListAsync();

            }
        }
    }
}
