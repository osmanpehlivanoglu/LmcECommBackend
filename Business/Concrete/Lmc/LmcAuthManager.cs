using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LmcAuthManager : ILmcAuthService
    {
        private readonly ILmcUserService _userService;
        private readonly ITokenHelper _tokenHelper;

        public LmcAuthManager(ILmcUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public LmcAuthManager(ITokenHelper tokenHelper)
        {
            _tokenHelper = tokenHelper;
        }

        public async Task<IDataResult<User>> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                UserType = userForRegisterDto.UserType,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                KimlikNo = userForRegisterDto.KimlikNo,
                Firma = userForRegisterDto.Firma,
                VergiDairesi = userForRegisterDto.VergiDairesi,
                VergiNumarasi = userForRegisterDto.VergiNumarasi,
                Email = userForRegisterDto.Email,
                Telefon = userForRegisterDto.Telefon,
                Adres = userForRegisterDto.Adres,
                City = userForRegisterDto.City,
                District = userForRegisterDto.City,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true,
                MailGrubu = userForRegisterDto.MailGrubu
            };
            await _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        public async Task<IDataResult<User>> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = await _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck.Data == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck.Data, Messages.SuccessfulLogin);
        }

        public async Task<IResult> UserExists(string email)
        {
            var checkinUser = await _userService.GetByMail(email);

            if (checkinUser.Data != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public async Task<IDataResult<AccessToken>> CreateAccessToken(User user)
        {
            var onAsama = await _userService.GetClaims(user);
            var claims = onAsama.Data;
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        
    }
}
