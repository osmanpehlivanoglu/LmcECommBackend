using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
    public class LmcToptanciManager : ILmcToptanciService
    {
        ILmcToptanciDal _toptanciDal;

        public LmcToptanciManager(ILmcToptanciDal toptanciDal)
        {
            _toptanciDal = toptanciDal;
        }

        [SecuredOperation("Admin")]
        public async Task<IResult> Add(Toptanci toptanci)
        {
            await _toptanciDal.Add(toptanci);
            return new SuccessResult(Messages.ToptanciEklendi);
        }

        public async Task<IResult> Delete(Toptanci toptanci)
        {
            await _toptanciDal.Delete(toptanci);
            return new SuccessResult(Messages.ToptanciSilindi);
        }

        public async Task<IDataResult<List<Toptanci>>> GetAll()
        {
            return new SuccessDataResult<List<Toptanci>>(await _toptanciDal.GetAll());
        }

        public async Task<IDataResult<Toptanci>> GetById(int toptanciId)
        {
            return new SuccessDataResult<Toptanci>(await _toptanciDal.Get(t=>t.ToptanciId == toptanciId));
        }

        public async Task<IResult> Update(Toptanci toptanci)
        {
            await _toptanciDal.Update(toptanci);
            return new SuccessResult(Messages.ToptanciGuncellendi);
        }
    }
}
