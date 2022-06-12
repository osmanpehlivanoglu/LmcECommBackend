using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LmcAlinanOdemeManager : ILmcAlinanOdemeService
    {
        ILmcAlinanOdemeDal _alinanOdemeDal;

        public LmcAlinanOdemeManager(ILmcAlinanOdemeDal alinanOdemeDal)
        {
            _alinanOdemeDal = alinanOdemeDal;
        }

        public async Task<IResult> Add(AlinanOdeme alinanOdeme)
        {
            await _alinanOdemeDal.Add(alinanOdeme);
            return new SuccessResult(Messages.AlinanOdemeEklendi);
        }

        public async Task<IResult> Delete(AlinanOdeme alinanOdeme)
        {
            await _alinanOdemeDal.Delete(alinanOdeme);
            return new SuccessResult(Messages.AlinanOdemeSilindi);
        }

        public async Task<IDataResult<List<AlinanOdeme>>> GetAll()
        {
            return new SuccessDataResult<List<AlinanOdeme>>(await _alinanOdemeDal.GetAll());
        }

        public async Task<IDataResult<List<AlinanOdeme>>> GetAllByMusteriId(int musteriId)
        {
            return new SuccessDataResult<List<AlinanOdeme>>(await _alinanOdemeDal.GetAll(a => a.MusteriId == musteriId));
        }

        public async Task<IDataResult<AlinanOdeme>> GetById(int alinanOdemeId)
        {
            return new SuccessDataResult<AlinanOdeme>(await _alinanOdemeDal.Get(a => a.AlinanOdemeId == alinanOdemeId));
        }

        public async Task<IResult> Update(AlinanOdeme alinanOdeme)
        {
            await _alinanOdemeDal.Update(alinanOdeme);
            return new SuccessResult(Messages.AlinanOdemeGuncellendi);
        }
    }
}
