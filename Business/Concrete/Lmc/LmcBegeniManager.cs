using Business.Abstract.Lmc;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Lmc
{
    public class LmcBegeniManager : ILmcBegeniService
    {
        ILmcBegeniDal _begeniDal;

        public LmcBegeniManager(ILmcBegeniDal begeniDal)
        {
            _begeniDal = begeniDal;
        }

        public async Task<IResult> Add(Begeni begeni)
        {
            await _begeniDal.Add(begeni);
            return new SuccessResult(Messages.BegeniEklendi);
        }

        public async Task<IResult> Delete(Begeni begeni)
        {
            await _begeniDal.Delete(begeni);
            return new SuccessResult(Messages.BegeniSilindi);
        }

        public async Task<IDataResult<List<Begeni>>> GetAll()
        {
            return new SuccessDataResult<List<Begeni>>(await _begeniDal.GetAll());
        }

        public async Task<IDataResult<Begeni>> GetById(int begeniId)
        {
            return new SuccessDataResult<Begeni>(await _begeniDal.Get(k => k.BegeniId == begeniId));
        }

        public async Task<IDataResult<List<Begeni>>> GetAllByKullaniciId(int kullaniciId)
        {
            return new SuccessDataResult<List<Begeni>>(await _begeniDal.GetAll(k => k.KullaniciId == kullaniciId));
        }

        public async Task<IResult> Update(Begeni begeni)
        {
            await _begeniDal.Update(begeni);
            return new SuccessResult(Messages.BegeniGuncellendi);
        }

        public async Task<IDataResult<List<BegeniDto>>> GetAllDto()
        {
            return new SuccessDataResult<List<BegeniDto>>(await _begeniDal.GetAllDto());
        }

        public async Task<IDataResult<List<BegeniDto>>> GetAllDtoByKullaniciId(int kullaniciId)
        {
            return new SuccessDataResult<List<BegeniDto>>(await _begeniDal.GetAllDto(b => b.KullaniciId == kullaniciId));
        }
    }
}
