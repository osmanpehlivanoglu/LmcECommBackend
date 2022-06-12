using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcUserService
    {
        Task<IDataResult<List<User>>> GetAll();
        Task<IDataResult<User>> GetById(int userId);
        Task<IResult> Add(User user);
        Task<IResult> Update(User user);
        Task<IResult> Delete(User user);


        //List<OperationClaim> GetClaims(User user);
        //User GetByMail(string email);


        Task<IDataResult<List<OperationClaim>>> GetClaims(User user);
        Task<IDataResult<User>> GetByMail(string email);

    }
}
