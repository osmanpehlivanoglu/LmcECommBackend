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
    public class LmcUyumMarkaManager : ILmcUyumMarkaService
    {
        ILmcUyumMarkaDal _uyumMarkaDal;

        public LmcUyumMarkaManager(ILmcUyumMarkaDal uyumMarkaDal)
        {
            _uyumMarkaDal = uyumMarkaDal;
        }

        public async Task<IResult> Add(UyumMarka uyumMarka)
        {
            await _uyumMarkaDal.Add(uyumMarka);
            return new SuccessResult(Messages.UyumMarkaEklendi);
        }

        public async Task<IResult> Delete(UyumMarka uyumMarka)
        {
            await _uyumMarkaDal.Delete(uyumMarka);
            return new SuccessResult(Messages.UyumMarkaSilindi);
        }

        public async Task<IDataResult<List<UyumMarka>>> GetAll()
        {
            return new SuccessDataResult<List<UyumMarka>>(await _uyumMarkaDal.GetAll());
        }


        public async Task<IDataResult<UyumMarka>> GetById(int uyumMarkaId)
        {
            return new SuccessDataResult<UyumMarka>(await _uyumMarkaDal.Get(u => u.UyumMarkaId == uyumMarkaId));
        }

        public async Task<IResult> Update(UyumMarka uyumMarka)
        {
            await _uyumMarkaDal.Update(uyumMarka);
            return new SuccessResult(Messages.UyumMarkaGuncellendi);
        }
    }
}
