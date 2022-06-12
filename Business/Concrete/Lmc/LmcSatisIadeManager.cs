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
    public class LmcSatisIadeManager:ILmcSatisIadeService
    {
        ILmcSatisIadeDal _satisIadeDal;

        public LmcSatisIadeManager(ILmcSatisIadeDal satisIadeDal)
        {
            _satisIadeDal = satisIadeDal;
        }

        public async Task<IResult> Add(SatisIade satisIade)
        {
            await _satisIadeDal.Add(satisIade);
            return new SuccessResult(Messages.SatisIadeEklendi);
        }

        public async Task<IResult> Delete(SatisIade satisIade)
        {
            await _satisIadeDal.Delete(satisIade);
            return new SuccessResult(Messages.SatisIadeSilindi);
        }

        public async Task<IDataResult<List<SatisIade>>> GetAll()
        {
            return new SuccessDataResult<List<SatisIade>>(await _satisIadeDal.GetAll());
        }

        public async Task<IDataResult<SatisIade>> GetBySatisId(int satisId)
        {
            return new SuccessDataResult<SatisIade>(await _satisIadeDal.Get(s=>s.SatisId == satisId));
        }

        public async Task<IDataResult<SatisIade>> GetById(int satisIadeId)
        {
            return new SuccessDataResult<SatisIade>(await _satisIadeDal.Get(s => s.SatisIadeId == satisIadeId));
        }

        public async Task<IResult> Update(SatisIade satisIade)
        {
            await _satisIadeDal.Update(satisIade);
            return new SuccessResult(Messages.SatisIadeGuncellendi);
        }

    }
}
