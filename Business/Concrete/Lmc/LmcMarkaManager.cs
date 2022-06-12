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
    public class LmcMarkaManager : ILmcMarkaService
    {
        ILmcMarkaDal _markaDal;

        public LmcMarkaManager(ILmcMarkaDal markaDal)
        {
            _markaDal = markaDal;
        }

        public async Task<IResult> Add(Marka marka)
        {
            await _markaDal.Add(marka);
            return new SuccessResult(Messages.MarkaEklendi);
        }

        public async Task<IResult> Delete(Marka marka)
        {
            await _markaDal.Delete(marka);
            return new SuccessResult(Messages.MarkaSilindi);
        }

        public async Task<IDataResult<List<Marka>>> GetAll()
        {
            return new SuccessDataResult<List<Marka>>(await _markaDal.GetAll());
        }

        public async Task<IDataResult<List<Marka>>> GetAllByKategoriId(int kategoriId)
        {
            return new SuccessDataResult<List<Marka>>(await _markaDal.GetAll(m => m.KategoriId == kategoriId));
        }

        public async Task<IDataResult<Marka>> GetById(int markaId)
        {
            return new SuccessDataResult<Marka>(await _markaDal.Get(m => m.MarkaId == markaId));
        }

        public async Task<IResult> Update(Marka marka)
        {
            await _markaDal.Update(marka);
            return new SuccessResult(Messages.MarkaGuncellendi);
        }
    }
}
