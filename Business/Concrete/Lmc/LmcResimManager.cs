using Business.Abstract;
using Business.Constants;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LmcResimManager : ILmcResimService
    {
        ILmcResimDal _resimDal;

        public LmcResimManager(ILmcResimDal resimDal)
        {
            _resimDal = resimDal;
        }

        public IResult Add(IFormFile file, Resim resim)
        {
            resim.ResimAdresi = ImageFileHelper.Add(file);
            resim.Tarih = DateTime.Now;
            _resimDal.AddSync(resim);
            return new SuccessResult(Messages.ResimEklendi);
        }

        public IResult Delete(Resim resim)
        {
            ImageFileHelper.Delete(resim.ResimAdresi);
            _resimDal.DeleteSync(resim);
            return new SuccessResult(Messages.ResimSilindi);
        }

        public IDataResult<List<Resim>> GetAll()
        {
            return new SuccessDataResult<List<Resim>>( _resimDal.GetAllSync());
        }

        public IDataResult<Resim> GetById(int resimId)
        {
            return new SuccessDataResult<Resim>(_resimDal.GetSync(r=>r.ResimId == resimId));
            
        }

        public IDataResult<List<Resim>> GetImagesByUrunId(int urunId)
        {
            return new SuccessDataResult<List<Resim>>(_resimDal.GetAllSync(r => r.UrunId == urunId));
        }

        public IResult Update(IFormFile file, Resim resim)
        {
            resim.ResimAdresi = ImageFileHelper.Update(_resimDal.GetSync(r => r.ResimId == resim.ResimId).ResimAdresi, file);
            resim.Tarih = DateTime.Now;
            _resimDal.UpdateSync(resim);
            return new SuccessResult(Messages.ResimGuncellendi);
        }

        
    }
}
