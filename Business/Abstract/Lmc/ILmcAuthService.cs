using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcAuthService
    {
        Task<IDataResult<User>> Register(UserForRegisterDto userForRegisterDto, string password);
        Task<IDataResult<User>> Login(UserForLoginDto userForLoginDto);
        Task<IResult> UserExists(string email);
        Task<IDataResult<AccessToken>> CreateAccessToken(User user);
    }
}
