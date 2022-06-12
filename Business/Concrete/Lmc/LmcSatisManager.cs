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
    public class LmcSatisManager : ILmcSatisService
    {
        ILmcSatisDal _satisDal;

        public LmcSatisManager(ILmcSatisDal satisDal)
        {
            _satisDal = satisDal;
        }

        public async Task<IResult> Add(Satis satis)
        {
            await _satisDal.Add(satis);
            return new SuccessResult(Messages.SatisEklendi);
        }

        public async Task<IResult> Delete(Satis satis)
        {
            await _satisDal.Delete(satis);
            return new SuccessResult(Messages.SatisSilindi);
        }

        public async Task<IDataResult<List<Satis>>> GetAll()
        {
            return new SuccessDataResult<List<Satis>>(await _satisDal.GetAll());
        }

        public async Task<IDataResult<Satis>> GetBySatisId(int satisId)
        {
            return new SuccessDataResult<Satis>(await _satisDal.Get(s => s.SatisId == satisId));
        }

        public async Task<IDataResult<Satis>> GetBySepetId(int sepetId)
        {
            return new SuccessDataResult<Satis>(await _satisDal.Get(s => s.SepetId == sepetId));
        }

        public async Task<IResult> Update(Satis satis)
        {
            await _satisDal.Update(satis);
            return new SuccessResult(Messages.SatisGuncellendi);
        }
    }
}
