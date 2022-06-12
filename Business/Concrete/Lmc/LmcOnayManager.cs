using Business.Abstract.Lmc;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Lmc
{
    public class LmcOnayManager : ILmcOnayService
    {
        ILmcOnayDal _onayDal;

        public LmcOnayManager(ILmcOnayDal onayDal)
        {
            _onayDal = onayDal;
        }

        public async Task<IResult> Add(Onay onay)
        {
            await _onayDal.Add(onay);
            return new SuccessResult(Messages.OnayEklendi);
            
        }

        public async Task<IResult> Delete(Onay onay)
        {
            await _onayDal.Delete(onay);
            return new SuccessResult(Messages.OnaySilindi);
        }

        public async Task<IDataResult<List<Onay>>> GetAll()
        {
            return new SuccessDataResult<List<Onay>>(await _onayDal.GetAll());
        }

        public async Task<IDataResult<Onay>> GetById(int onayId)
        {
            return new SuccessDataResult<Onay>(await _onayDal.Get(o => o.OnayId == onayId));
        }

        public async Task<IResult> Update(Onay onay)
        {
            await _onayDal.Update(onay);
            return new SuccessResult(Messages.OnayGuncellendi);
        }
    }
}
