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
    public class LmcKategoriManager : ILmcKategoriService
    {
        ILmcKategoriDal _kategoriDal;

        public LmcKategoriManager(ILmcKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public async Task<IResult> Add(Kategori kategori)
        {
            await _kategoriDal.Add(kategori);
            return new SuccessResult(Messages.KategoriEklendi);
        }

        public async Task<IResult> Delete(Kategori kategori)
        {
            await _kategoriDal.Delete(kategori);
            return new SuccessResult(Messages.KategoriSilindi);
        }

        public async Task<IDataResult<List<Kategori>>> GetAll()
        {
            return new SuccessDataResult<List<Kategori>>(await _kategoriDal.GetAll());
        }

        public async Task<IDataResult<Kategori>> GetById(int kategoriId)
        {
            return new SuccessDataResult<Kategori>(await _kategoriDal.Get(k => k.KategoriId == kategoriId));
        }

        public async Task<IResult> Update(Kategori kategori)
        {
            await _kategoriDal.Update(kategori);
            return new SuccessResult(Messages.KategoriGuncellendi);
        }

        //public IResult Add(Kategori kategori)
        //{
        //    _kategoriDal.Add(kategori);
        //    return new SuccessResult(Messages.KategoriEklendi);
        //}

        //public IResult Delete(Kategori kategori)
        //{
        //    _kategoriDal.Delete(kategori);
        //    return new SuccessResult(Messages.KategoriSilindi);
        //}

        //public IDataResult<List<Kategori>> GetAll()
        //{
        //    return new SuccessDataResult<List<Kategori>>(_kategoriDal.GetAll());
        //}

        //public IDataResult<Kategori> GetById(int kategoriId)
        //{
        //    return new SuccessDataResult<Kategori>(_kategoriDal.Get(k => k.KategoriId == kategoriId));
        //}

        //public IResult Update(Kategori kategori)
        //{
        //    _kategoriDal.Update(kategori);
        //    return new SuccessResult(Messages.KategoriGuncellendi);
        //}
    }
}
