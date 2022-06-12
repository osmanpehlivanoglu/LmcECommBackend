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
    public class LmcSatinAlimManager : ILmcSatinAlimService
    {
        ILmcSatinAlimDal _satinAlimDal;

        public LmcSatinAlimManager(ILmcSatinAlimDal satinAlimDal)
        {
            _satinAlimDal = satinAlimDal;
        }

        public async Task<IResult> Add(SatinAlim SatinAlim)
        {
            await _satinAlimDal.Add(SatinAlim);
            return new SuccessResult(Messages.SatinAlimEklendi);
        }

        public async Task<IResult> Delete(SatinAlim SatinAlim)
        {
            await _satinAlimDal.Delete(SatinAlim);
            return new SuccessResult(Messages.SatinAlimSilindi);
        }

        public async Task<IDataResult<List<SatinAlim>>> GetAll()
        {
            return new SuccessDataResult<List<SatinAlim>>(await _satinAlimDal.GetAll());
        }

        public async Task<IDataResult<SatinAlim>> GetBySatinAlimId(int satinAlimId)
        {
            return new SuccessDataResult<SatinAlim>(await _satinAlimDal.Get(s => s.SatinAlimId == satinAlimId));
        }

        public async Task<IDataResult<SatinAlim>> GetBySepetId(int sepetId)
        {
            return new SuccessDataResult<SatinAlim>(await _satinAlimDal.Get(s => s.SepetId == sepetId));
        }


        public async Task<IResult> Update(SatinAlim SatinAlim)
        {
            await _satinAlimDal.Update(SatinAlim);
            return new SuccessResult(Messages.SatinAlimGuncellendi);
        }
    }
}
