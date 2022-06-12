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
    public class LmcSatinAlimIadeManager:ILmcSatinAlimIadeService
    {
        ILmcSatinAlimIadeDal _satinAlimIadeDal;

        public LmcSatinAlimIadeManager(ILmcSatinAlimIadeDal satinAlimIadeDal)
        {
            _satinAlimIadeDal = satinAlimIadeDal;
        }

        public async Task<IResult> Add(SatinAlimIade SatinAlimIade)
        {
            await _satinAlimIadeDal.Add(SatinAlimIade);
            return new SuccessResult(Messages.SatinAlimIadeEklendi);
        }

        public async Task<IResult> Delete(SatinAlimIade SatinAlimIade)
        {
            await _satinAlimIadeDal.Delete(SatinAlimIade);
            return new SuccessResult(Messages.SatinAlimIadeSilindi);
        }

        public async Task<IDataResult<List<SatinAlimIade>>> GetAll()
        {
            return new SuccessDataResult<List<SatinAlimIade>>(await _satinAlimIadeDal.GetAll());
        }

        public async Task<IDataResult<SatinAlimIade>> GetBySatinAlimId(int satinAlimId)
        {
            return new SuccessDataResult<SatinAlimIade>(await _satinAlimIadeDal.Get(s => s.SatinAlimId == satinAlimId));
        }

        public async Task<IDataResult<SatinAlimIade>> GetById(int SatinAlimIadeId)
        {
            return new SuccessDataResult<SatinAlimIade>(await _satinAlimIadeDal.Get(s => s.SatinAlimIadeId == SatinAlimIadeId));
        }

        public async Task<IResult> Update(SatinAlimIade SatinAlimIade)
        {
            await _satinAlimIadeDal.Update(SatinAlimIade);
            return new SuccessResult(Messages.SatinAlimIadeGuncellendi);
        }
    }
}
